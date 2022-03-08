using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using Consistent_Overhead_Byte_Stuffing;

namespace WindowsFormsApp3
{
    public class PacketSerial
    {
       
        SerialPort _stream;
        int PacketMarker = 0;
        int _receiveBufferIndex = 0;
        byte[] _receiveBuffer;
        bool _recieveBufferOverflow;
        int _ReceiveBufferSize;

        public delegate void PacketHandlerFunction(ref byte[] bytes, int size);
        PacketHandlerFunction _onPacketFunction;

        public PacketSerial(int ReceiveBufferSize=256)
        {
            this._ReceiveBufferSize = ReceiveBufferSize;
            this._receiveBuffer = new byte[this._ReceiveBufferSize];
            
        }
        public void setStream(SerialPort stream)
        {
            _stream = stream;
        }
        public SerialPort getStream()
        {
            return _stream;
        }

        public void update()
        {
            if (_stream == null) return;

            while (_stream.BytesToRead > 0)
            {
                byte data = (byte)_stream.ReadByte();

                if (data == this.PacketMarker)
                {
                    if (this._onPacketFunction != null)
                    {
                        byte[] _decodeBuffer = new byte[this._receiveBufferIndex];

                        int numDecoded = COBS.cobs_decode(ref this._receiveBuffer, this._receiveBufferIndex, ref _decodeBuffer);

                        // clear the index here so that the callback function can call update() if needed and receive more data
                        this._receiveBufferIndex = 0;
                        this._recieveBufferOverflow = false;

                        if (this._onPacketFunction != null)
                        {
                            this._onPacketFunction(ref _decodeBuffer, numDecoded);
                        }

                    }
                    else
                    {
                        this._receiveBufferIndex = 0;
                        this._recieveBufferOverflow = false;
                    }
                }
                else
                {
                    if ((this._receiveBufferIndex + 1) < this._ReceiveBufferSize)
                    {
                        this._receiveBuffer[this._receiveBufferIndex++] = data;
                    }
                    else
                    {
                        // The buffer will be in an overflowed state if we write
                        // so set a buffer overflowed flag.
                        this._recieveBufferOverflow = true;
                    }
                }
            }
        }

        static int getEncodedBufferSize(int unencodedBufferSize)
        {
            return unencodedBufferSize + unencodedBufferSize / 254 + 1;
        }

        public void send(ref byte[] buffer, int size)
        {
            if(_stream.Equals(null) || buffer.Equals(null) || size == 0) return;

            byte[] _encodeBuffer = new byte[PacketSerial.getEncodedBufferSize(size)];

            int numEncoded = COBS.cobs_encode(ref buffer, size, ref _encodeBuffer);

            byte[] m = new byte[1];
            m[0] = (byte)this.PacketMarker;
          
            _stream.Write(_encodeBuffer, 0, numEncoded);
            _stream.Write(m, 0, 1);
        }

    /// \brief Set the function that will receive decoded packets.
    ///
    /// This function will be called when data is read from the serial stream
    /// connection and a packet is decoded. The decoded packet will be passed
    /// to the packet handler. The packet handler must have the form:
    ///
    /// The packet handler method usually has the form:
    ///
    ///     void onPacketReceived(const uint8_t* buffer, size_t size);
    ///
    /// The packet handler would then be registered like this:
    ///
    ///     myPacketSerial.setPacketHandler(&onPacketReceived);
    ///
    /// Setting a packet handler will remove all other packet handlers.
    ///
    /// \param onPacketFunction A pointer to the packet handler function.
    public void setPacketHandler(PacketHandlerFunction onPacketFunction)
    {
        _onPacketFunction = onPacketFunction;
    }

    /// \brief Set the function that will receive decoded packets.
    ///
    /// This function will be called when data is read from the serial stream
    /// connection and a packet is decoded. The decoded packet will be passed
    /// to the packet handler. The packet handler must have the form:
    ///
    /// The packet handler method usually has the form:
    ///
    ///     void onPacketReceived(const void* sender, const uint8_t* buffer, size_t size);
    ///
    /// To determine the sender, compare the pointer to the known possible
    /// PacketSerial senders.
    ///
    ///     void onPacketReceived(void* sender, const uint8_t* buffer, size_t size)
    ///     {
    ///         if (sender == &myPacketSerial)
    ///         {
    ///             // Do something with the packet from myPacketSerial.
    ///         }
    ///         else if (sender == &myOtherPacketSerial)
    ///         {
    ///             // Do something with the packet from myOtherPacketSerial.
    ///         }
    ///     }
    ///
    /// The packet handler would then be registered like this:
    ///
    ///     myPacketSerial.setPacketHandler(&onPacketReceived);
    ///
    /// You can also register an arbitrary void* pointer to be passed to your packet handler method.
    /// This is most useful when PacketSerial is used inside a class, to pass a pointer to
    /// the containing class:
    ///
    ///     class EchoClass {
    ///       public:
    ///         void begin(unsigned long speed) {
    ///           myPacketSerial.setPacketHandler(&onPacketReceived, this);
    ///           myPacketSerial.begin(speed);
    ///         }
    ///     
    ///         // C-style callbacks can't use non-static methods,
    ///         // so we use a static method that receives "this" as the sender argument:
    ///         // https://wiki.c2.com/?VirtualStaticIdiom
    ///         static void onPacketReceived(const void* sender, const uint8_t* buffer, size_t size) {
    ///           ((EchoClass*)sender)->onPacketReceived(buffer, size);
    ///         }
    ///     
    ///         void onPacketReceived(const uint8_t* buffer, size_t size) {
    ///             // we can now use myPacketSerial as needed here
    ///         }
    ///     
    ///         PacketSerial myPacketSerial;
    ///     };
    ///
    /// Setting a packet handler will remove all other packet handlers.
    ///
    /// \param onPacketFunctionWithSender A pointer to the packet handler function.


    /// \brief Check to see if the receive buffer overflowed.
    ///
    /// This must be called often, directly after the `update()` function.
    ///
    ///     void loop()
    ///     {
    ///         // Other program code.
    ///         myPacketSerial.update();
    ///
    ///         // Check for a receive buffer overflow.
    ///         if (myPacketSerial.overflow())
    ///         {
    ///             // Send an alert via a pin (e.g. make an overflow LED) or return a
    ///             // user-defined packet to the sender.
    ///             //
    ///             // Ultimately you may need to just increase your recieve buffer via the
    ///             // template parameters.
    ///         }
    ///     }
    ///
    /// The state is reset every time a new packet marker is received NOT when 
    /// overflow() method is called.
    ///
    /// \returns true if the receive buffer overflowed.
    bool overflow()
    {
        return this._recieveBufferOverflow;
    }


    }
}

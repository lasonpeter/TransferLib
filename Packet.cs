﻿namespace TransferLib;

public class Packet
{
    private byte[] _payload = new byte[4096];
    private PacketType _packetType;
    public readonly ushort Version = 1;
    private ushort _messageLength;
    private byte[] _data = new byte[4_099];
    public byte[] Payload => _payload;
    public PacketType PacketType => _packetType;
    public ushort MessageLength => _messageLength;
    public Packet(){} 
    /// <summary>
    /// Packet creator, creates the packet and assumes the length of payload from the payload parameter length
    /// </summary>
    /// <param name="payload">byte array payload to be transferred</param>
    /// <param name="pType">packet type</param>
    public Packet(byte[] payload, PacketType pType)
    {
        _payload = payload;
        _packetType = pType;
        _messageLength = (ushort)payload.Length;
    }
    /// <summary>
    /// Packet creator, creates the packet with packet length
    /// </summary>
    /// <param name="payload">byte array payload to be transferred</param>
    /// <param name="pType">packet type</param>
    /// <param name="length">length of payload</param>
    public Packet(byte[] payload, PacketType pType,int length)
    {
        _payload = payload;
        _packetType = pType;
        _messageLength = (ushort)length;
    }
    public Packet(PacketType packetType)
    {
        _packetType = packetType;
    }
    /// <summary>
    /// Decodes the packet from byte array
    /// </summary>
    /// <param name="data">data to decode the packet from</param>
    public void DecodePacket(byte[] data)
    {
        Array.Clear(_payload);
        _packetType = (PacketType)data[0];
        _messageLength = BitConverter.ToUInt16(data, 1);
        new ArraySegment<byte>(data, 3, 4096).CopyTo(_payload);
    }
    /// <summary>
    /// Composes the packet from payload and Packet type (writes to the self)
    /// </summary>
    /// <param name="payload"></param>
    /// <param name="pType"></param>
    public void Compose(byte[] payload, PacketType pType)
    {
        _payload = payload;
        _packetType = pType;
        _messageLength = (ushort)payload.Length;
    }
    /// <summary>
    /// Returns the serialized packet which can be decoded by <see cref="DecodePacket"/> 
    /// </summary>
    /// <returns></returns>
    public byte[] ToBytes()
    {
        _data[0] = (byte)_packetType;
        BitConverter.GetBytes(_messageLength).CopyTo(_data,1);
        _payload.CopyTo(_data,3);
        return _data;
    }
}
public class PacketEventArgs : EventArgs
{
    public Packet Packet { get; set; }
    public PacketEventArgs(Packet packet)
    {
        Packet = packet;
    }
}
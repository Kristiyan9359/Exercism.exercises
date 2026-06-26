public static class TelemetryBuffer
{
public static byte[] ToBuffer(long reading)
{
    byte[] buffer = new byte[9];
    byte[] payload;

    if (reading >= 0 && reading <= ushort.MaxValue)
    {
        buffer[0] = 2;
        payload = BitConverter.GetBytes((ushort)reading);
    }
    else if (reading >= ushort.MaxValue + 1L && reading <= int.MaxValue)
    {
        buffer[0] = 0xfc;
        payload = BitConverter.GetBytes((int)reading);
    }
    else if (reading >= (long)int.MaxValue + 1L && reading <= uint.MaxValue)
    {
        buffer[0] = 4;
        payload = BitConverter.GetBytes((uint)reading);
    }
    else if (reading >= (long)uint.MaxValue + 1L)
    {
        buffer[0] = 0xf8;
        payload = BitConverter.GetBytes(reading);
    }
    else if (reading >= short.MinValue && reading <= -1)
    {
        buffer[0] = 0xfe;
        payload = BitConverter.GetBytes((short)reading);
    }
    else if (reading >= int.MinValue && reading <= short.MinValue - 1L)
    {
        buffer[0] = 0xfc;
        payload = BitConverter.GetBytes((int)reading);
    }
    else
    {
        buffer[0] = 0xf8;
        payload = BitConverter.GetBytes(reading);
    }

    for (int i = 0; i < payload.Length; i++)
    {
        buffer[i + 1] = payload[i];
    }

    return buffer;
}


    public static long FromBuffer(byte[] buffer)
{
    switch (buffer[0])
    {
        case 2:
            return BitConverter.ToUInt16(buffer, 1);

        case 4:
            return BitConverter.ToUInt32(buffer, 1);

        case 0xfe:
            return BitConverter.ToInt16(buffer, 1);

        case 0xfc:
            return BitConverter.ToInt32(buffer, 1);

        case 0xf8:
            return BitConverter.ToInt64(buffer, 1);

        default:
    return 0;

    }
}

}

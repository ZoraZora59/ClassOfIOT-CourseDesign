class transducerServer
{
    string ip;
    int port;
    int freq;
    int light;
    public void setIp(string ip)
    {
        this.ip = ip;
    }
    public void setLight(int light)
    {
        this.light = light;
    }
    public void setPort(int port)
    {
        this.port = port;
    }
    public void setFreq(int freq)
    {
        this.freq = freq;
    }
    public string getIp()
    {
        return this.ip;
    }
    public int getPort()
    {
        return this.port;
    }
    public int getFreq()
    {
        return freq;
    }

}
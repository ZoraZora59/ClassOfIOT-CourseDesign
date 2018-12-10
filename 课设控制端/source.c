#define serial1 ""	//串口名
#define serial2 ""
#define serial3 ""

int g_fd;		//文件描述符
int g_fdLight;	//灯光
int g_fdCurtain;//窗帘
int g_fdAirConditioner;//空调

int InitSerial(int fd, int baudrate)//初始化串口
{ 
	return fd;
}

void LightingCtrl (char portID,char state)//灯光控制系统，实现获取光照强度并改变灯光亮灭状态
{
	InitSerial(g_fdLight,9600);
	char cmd[8];
	SendCmd(cmd,portID);//向传感器发送命令读取光照强度
	cmd=ReceiveCmd();//传感器接收光照强度的数据
	illuminationLevel=DataProcessing(cmd);//获取处理后的光强数据
}

void CurtainCtrl (char portID,char state)//窗帘控制系统，实现点击按钮改变窗帘开合状态
{
	InitSerial(g_fdCurtain,9600);
	char cmd[8];
	SendCmd(cmd,portID);//根据窗帘的开合状态向传感器发送命令改变状态
}

void AirConditionerCtrl (char portID,char state)//空调控制系统，实现获取温度强度并改变空调温度
{
	InitSerial(g_fdAirConditioner,9600);
	char cmd[8];
	SendCmd(cmd,portID);//向传感器发送命令读取温度强度
	cmd=ReceiveCmd();//传感器接收温度强度的数据
	temperatureLevel=DataProcessing(cmd);//获取处理后的温度数据
}

void SendCmd(char cmd,int portID)//向传感器发送指令。cmd：指令；portID：端口号；flag：值为1表示发送成功
{
	short flag=0;
	while(flag==0)
	{
		
	}
}

int ReceiveCmd()//从传感器接收指令
{
	char cmd[8];	//cmd：接收到的指令；
	short flag=0;
	while(flag==0)
	{
		
	}
	return cmd;
}

int DataProcessing(char cmd)//对接收的数据进行处理得到光强
{
	return dataLevel;
}






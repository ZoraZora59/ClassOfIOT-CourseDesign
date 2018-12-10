#define serial1 ""	//串口名
#define serial2 ""
#define serial3 ""

int g_fd;		//文件描述符
int g_fdLight;	//灯光
int g_fdCurtain;//窗帘
int g_fdAirConditioner;//空调

int main()
{}

struct listener(var socketData)//循环执行，监听端口指令，返回指令数据的清洗后内容
{}

int initSerial(int fd, int baudrate)//初始化串口
{}

var socket()//数据传递部分，等待下版本处理
{}

var processer()//根据指令信息调用相应函数
{}

int getLightLevel(char portID)//通过参数提供的串口进行数据获取，返回光照强度十进制数据。
{}

int lightingCtrl (char portID)//通过参数提供的串口对灯光进行控制，将灯光取反，返回当前灯光状态，亮1灭0。
{}

int getCurtain(char portID)//通过参数提供的串口返回窗帘当前状态值
{}

void curtainCtrl (char portID,char state)//通过参数提供的串口和状态值对窗帘进行控制，将窗帘状态设为参数状态值
{}

void airConditionerCtrl (char portID,char state)//通过参数提供的串口和状态值改变空调温度
{}

int getAirConditioner(char portID)//通过参数提供的串口获取空调当前温度
{}

int sendCmd(char cmd,int portID)//向传感器发送指令。cmd：指令；portID：端口号；flag：值为1表示发送成功
{}

int receiveCmd()//从传感器接收指令
{}

int dataProcessing(char cmd)//对接收的数据进行处理得到光强
{}






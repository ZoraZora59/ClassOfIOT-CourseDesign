# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'MainView.ui'
#
# Created by: PyQt5 UI code generator 5.11.3
#
# WARNING! All changes made in this file will be lost!
from PyQt5 import QtCore, QtGui, QtWidgets


class Ui_MainView(object):
	def setupUi(self, MainView):
		MainView.setObjectName("MainView")
		MainView.setWindowModality(QtCore.Qt.ApplicationModal)
		MainView.setEnabled(True)
		MainView.resize(600, 450)
		sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Preferred, QtWidgets.QSizePolicy.Preferred)
		sizePolicy.setHorizontalStretch(0)
		sizePolicy.setVerticalStretch(0)
		sizePolicy.setHeightForWidth(MainView.sizePolicy().hasHeightForWidth())
		MainView.setSizePolicy(sizePolicy)
		MainView.setMinimumSize(QtCore.QSize(600, 450))
		MainView.setMaximumSize(QtCore.QSize(600, 450))
		font = QtGui.QFont()
		font.setFamily("微软雅黑")
		MainView.setFont(font)
		icon = QtGui.QIcon()
		icon.addPixmap(QtGui.QPixmap("F:/FFOutput/未标题-1.ico"), QtGui.QIcon.Normal, QtGui.QIcon.Off)
		MainView.setWindowIcon(icon)
		self.centralwidget = QtWidgets.QWidget(MainView)
		self.centralwidget.setEnabled(True)
		self.centralwidget.setObjectName("centralwidget")
		self.groupBoxInput = QtWidgets.QGroupBox(self.centralwidget)
		self.groupBoxInput.setEnabled(True)
		self.groupBoxInput.setGeometry(QtCore.QRect(30, 20, 531, 201))
		sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
		sizePolicy.setHorizontalStretch(0)
		sizePolicy.setVerticalStretch(0)
		sizePolicy.setHeightForWidth(self.groupBoxInput.sizePolicy().hasHeightForWidth())
		self.groupBoxInput.setSizePolicy(sizePolicy)
		self.groupBoxInput.setObjectName("groupBoxInput")
		self.lableCurtainIP = QtWidgets.QLabel(self.groupBoxInput)
		self.lableCurtainIP.setGeometry(QtCore.QRect(30, 30, 72, 15))
		self.lableCurtainIP.setObjectName("lableCurtainIP")
		self.labelTransIP = QtWidgets.QLabel(self.groupBoxInput)
		self.labelTransIP.setGeometry(QtCore.QRect(20, 80, 91, 16))
		self.labelTransIP.setObjectName("labelTransIP")
		self.textTransIP = QtWidgets.QTextEdit(self.groupBoxInput)
		self.textTransIP.setGeometry(QtCore.QRect(110, 70, 241, 31))
		self.textTransIP.setReadOnly(False)
		self.textTransIP.setObjectName("textTransIP")
		self.textCurtainIP = QtWidgets.QTextEdit(self.groupBoxInput)
		self.textCurtainIP.setGeometry(QtCore.QRect(110, 20, 241, 31))
		self.textCurtainIP.setReadOnly(False)
		self.textCurtainIP.setObjectName("textCurtainIP")
		self.labelCurtainPort = QtWidgets.QLabel(self.groupBoxInput)
		self.labelCurtainPort.setGeometry(QtCore.QRect(370, 30, 31, 16))
		self.labelCurtainPort.setObjectName("labelCurtainPort")
		self.labelTransPort = QtWidgets.QLabel(self.groupBoxInput)
		self.labelTransPort.setGeometry(QtCore.QRect(370, 80, 31, 16))
		self.labelTransPort.setObjectName("labelTransPort")
		self.textTransPort = QtWidgets.QTextEdit(self.groupBoxInput)
		self.textTransPort.setGeometry(QtCore.QRect(410, 70, 81, 31))
		self.textTransPort.setReadOnly(False)
		self.textTransPort.setObjectName("textTransPort")
		self.textCurtainPort = QtWidgets.QTextEdit(self.groupBoxInput)
		self.textCurtainPort.setGeometry(QtCore.QRect(410, 20, 81, 31))
		self.textCurtainPort.setReadOnly(False)
		self.textCurtainPort.setObjectName("textCurtainPort")
		self.labelFreq = QtWidgets.QLabel(self.groupBoxInput)
		self.labelFreq.setGeometry(QtCore.QRect(50, 120, 141, 21))
		self.labelFreq.setObjectName("labelFreq")
		self.textFreq = QtWidgets.QTextEdit(self.groupBoxInput)
		self.textFreq.setGeometry(QtCore.QRect(190, 110, 101, 31))
		self.textFreq.setReadOnly(False)
		self.textFreq.setObjectName("textFreq")
		self.labelLightCheck = QtWidgets.QLabel(self.groupBoxInput)
		self.labelLightCheck.setGeometry(QtCore.QRect(310, 120, 61, 16))
		self.labelLightCheck.setObjectName("labelLightCheck")
		self.textLightCheck = QtWidgets.QTextEdit(self.groupBoxInput)
		self.textLightCheck.setGeometry(QtCore.QRect(380, 110, 81, 31))
		self.textLightCheck.setReadOnly(False)
		self.textLightCheck.setObjectName("textLightCheck")
		self.ButtonRun = QtWidgets.QPushButton(self.groupBoxInput)
		self.ButtonRun.setGeometry(QtCore.QRect(210, 150, 100, 40))
		self.ButtonRun.setObjectName("ButtonRun")
		self.groupBoxController = QtWidgets.QGroupBox(self.centralwidget)
		self.groupBoxController.setEnabled(False)
		self.groupBoxController.setGeometry(QtCore.QRect(30, 220, 531, 191))
		self.groupBoxController.setObjectName("groupBoxController")
		self.ButtonOn = QtWidgets.QPushButton(self.groupBoxController)
		self.ButtonOn.setGeometry(QtCore.QRect(320, 40, 131, 41))
		self.ButtonOn.setObjectName("ButtonOn")
		self.ButtonOff = QtWidgets.QPushButton(self.groupBoxController)
		self.ButtonOff.setGeometry(QtCore.QRect(320, 110, 131, 41))
		self.ButtonOff.setObjectName("ButtonOff")
		self.OutPutText = QtWidgets.QLabel(self.groupBoxController)
		self.OutPutText.setGeometry(QtCore.QRect(120, 40, 151, 41))
		self.OutPutText.setObjectName("OutPutText")
		self.ButtonCancel = QtWidgets.QPushButton(self.groupBoxController)
		self.ButtonCancel.setGeometry(QtCore.QRect(110, 110, 121, 41))
		self.ButtonCancel.setObjectName("ButtonCancel")
		self.groupBoxController.raise_()
		self.groupBoxInput.raise_()
		MainView.setCentralWidget(self.centralwidget)
		self.statusbar = QtWidgets.QStatusBar(MainView)
		self.statusbar.setObjectName("statusbar")
		MainView.setStatusBar(self.statusbar)

		self.ButtonRun.clicked.connect(self.setDown)
		self.ButtonCancel.clicked.connect(self.cancelConnection)
		self.ButtonOn.clicked.connect(self.openCurtain)
		self.ButtonOff.clicked.connect(self.closeCurtain)

		self.retranslateUi(MainView)
		QtCore.QMetaObject.connectSlotsByName(MainView)
		MainView.setTabOrder(self.textCurtainIP, self.textCurtainPort)
		MainView.setTabOrder(self.textCurtainPort, self.textTransIP)
		MainView.setTabOrder(self.textTransIP, self.textTransPort)
		MainView.setTabOrder(self.textTransPort, self.textFreq)
		MainView.setTabOrder(self.textFreq, self.textLightCheck)
		MainView.setTabOrder(self.textLightCheck, self.ButtonRun)
		MainView.setTabOrder(self.ButtonRun, self.ButtonOn)
		MainView.setTabOrder(self.ButtonOn, self.ButtonOff)
		MainView.setTabOrder(self.ButtonOff, self.ButtonCancel)

	def retranslateUi(self, MainView):
		_translate = QtCore.QCoreApplication.translate
		MainView.setWindowTitle(_translate("MainView", "物联网智能教室"))
		self.groupBoxInput.setTitle(_translate("MainView", "设置台"))
		self.lableCurtainIP.setText(_translate("MainView", "窗帘IP地址"))
		self.labelTransIP.setText(_translate("MainView", "传感器IP地址"))
		self.labelCurtainPort.setText(_translate("MainView", "端口"))
		self.labelTransPort.setText(_translate("MainView", "端口"))
		self.labelFreq.setText(_translate("MainView", "<html><head/><body><p>自动检测频率（ms）</p></body></html>"))
		self.labelLightCheck.setText(_translate("MainView", "亮度指标"))
		self.ButtonRun.setText(_translate("MainView", "设置确定"))
		self.groupBoxController.setTitle(_translate("MainView", "控制台"))
		self.ButtonOn.setText(_translate("MainView", "开窗帘"))
		self.ButtonOff.setText(_translate("MainView", "关窗帘"))
		self.OutPutText.setText(_translate("MainView", "亮度值：待测定"))
		self.ButtonCancel.setText(_translate("MainView", "断开连接"))
		self.textCurtainIP.setText(_translate("MainView", "192.168.0.66"))
		self.textCurtainPort.setText(_translate("MainView", "8124"))
		self.textFreq.setText(_translate("MainView", "500"))
		self.textLightCheck.setText(_translate("MainView", "500"))
		self.textTransIP.setText(_translate("MainView", "192.168.0."))
		self.textTransPort.setText(_translate("MainView", "4001"))

	def setDown(self):
		try:
			self.statusbar.showMessage("正在获取数据...")
			transIP = self.textTransIP.toPlainText()  # 获取文本框内容  toPlainText
			transPort = self.textTransPort.toPlainText()
			curtainIP = self.textCurtainIP.toPlainText()
			curtainPort = self.textCurtainPort.toPlainText()
			freq = self.textFreq.toPlainText()
			check = self.textLightCheck.toPlainText()
			print('Message: transIP %s transPort %s curtainIP %s curtainPort %s freq %s check %s' % (transIP, transPort, curtainIP, curtainPort, freq, check))
			self.statusbar.showMessage("正在建立连接...")
			self.sendCommand()
		except ConnectionError:
			self.statusbar.showMessage("建立连接失败")
			print("Error in connecting.")
		except all:
			self.statusbar.showMessage("获取信息失败")
			print("Error in getting message.")
		else:
			self.statusbar.showMessage("连接建立，控制台已激活")
			self.groupBoxInput.setEnabled(False)
			self.groupBoxController.setEnabled(True)

	def sendCommand(self):
		print("Running SendCommand.")
		pass

	def cancelConnection(self):
		try:
			print("Running CancelConnection.")
			self.statusbar.showMessage("正在断开连接")
		except all:
			print("Error in cancelling connection.")
			self.statusbar.showMessage("断开连接失败")
		else:
			# self.OutPutText.setText("亮度值：待测定")
			# self.textCurtainIP.setText("192.168.0.66")
			# self.textCurtainPort.setText("8124")
			# self.textFreq.setText("500")
			# self.textLightCheck.setText("500")
			# self.textTransIP.setText("192.168.0.")
			# self.textTransPort.setText("4001")
			self.statusbar.showMessage("连接已关闭")
			self.groupBoxInput.setEnabled(True)
			self.groupBoxController.setEnabled(False)
		pass

	def openCurtain(self):
		try:
			self.statusbar.showMessage("正在打开窗帘...")
			print("Running open curtain.")
		except all:
			self.statusbar.showMessage("打开窗帘失败")
			print("Error in opening curtain.")
		else:
			self.statusbar.showMessage("命令已发送")
		pass

	def closeCurtain(self):
		try:
			self.statusbar.showMessage("正在关闭窗帘...")
			print("Running close curtain.")
		except all:
			self.statusbar.showMessage("关闭窗帘失败")
			print("Error in closing curtain.")
		else:
			self.statusbar.showMessage("命令已发送")
		pass

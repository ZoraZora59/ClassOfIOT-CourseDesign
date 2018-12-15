import sys
import MainView
from PyQt5.QtWidgets import QApplication, QMainWindow

if __name__ == '__main__':
    app = QApplication(sys.argv)
    MainWindow = QMainWindow()
    ui = MainView.Ui_MainView()
    ui.setupUi(MainWindow)
    MainWindow.show()
    sys.exit(app.exec_())

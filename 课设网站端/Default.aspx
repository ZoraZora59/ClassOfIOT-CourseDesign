<%@ Page Title="物联网智能家居系统" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="课设网站端._Default" %>

<asp:Content ID="Default" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>智能家居系统V0.1
        </h1>
        <p class="lead">开发组名单：</p>
        <div>
            <p class="lead">总体设计与asp.net开发       纪玉涵</p>    
            <p class="lead">嵌入式c语言开发             易添</p>
            <p class="lead">QA测试                     张伊莎</p>
        </div>
        
        
        <p><a href="About" class="btn btn-primary btn-lg">项目介绍 &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>窗帘控制</h2>
            <p>
                基于ZigBee窗帘控制器和ZigBee协调器进行电动窗帘的控制。
            </p>
            <p>
                <a class="btn btn-default" href="CurtainControl">进入管理 &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>空调控制</h2>
            <p>
                基于ZigBee红外传感器和ZigBee协调器，通过RF 2.4G进行空调控制。
            </p>
            <p>
                <a class="btn btn-default" href="AirConditionerControl">进入管理 &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>灯光控制</h2>
            <p>
                基于ZigBee智能开关和ZigBee协调器进行灯光的基本开关控制。
            </p>
            <p>
                <a class="btn btn-default" href="LightControl">进入管理 &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>

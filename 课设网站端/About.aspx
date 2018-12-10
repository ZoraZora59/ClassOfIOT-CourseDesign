<%@ Page Title="系统介绍" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="课设网站端.About" %>

<asp:Content ID="About" ContentPlaceHolderID="MainContent" runat="server">
    <h2>系统详细介绍</h2>
    <p>本系统综合使用大部分物联网专业知识，目的是设计一个简单、但完整的物联网应用系统，以提高我们的物联网系统的开发能力。</p>
    <div>
        <p>
            Version0.1  搭建基本框架，完成开发构想。<br />
            Version0.2  完成类与接口的设计。<br />
            Version0.3  完成显示效果。<br />
            Version0.4  完成通信测试。<br /><br />
            Version1.0  完成灯光控制模块，实现局域网内控制灯光效果。<br />
        </p>
    </div>
    <h3>组内职责分配</h3>
    <div>
        <strong>Team.GK</strong>
        <br />
        纪玉涵（组长）：ASP.NET开发，协助通信模块开发，系统设计，文档编写。<br />
        易添：传感器数据获取与处理模块的开发，通信模块开发，文档编写。<br />
        张伊莎：程序测试，协助Debug，文档编写。<br />
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>¡Welcome, 
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        !</h1>
    <div id="listBox">
    <asp:ListBox ID="nameStudents" runat="server" Height="293px" Width="154px"></asp:ListBox></div>
    <div id="datos">
        <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Surname:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Age:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Address:"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="DNI:"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        
    </asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="WebApplication.Students.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>¡Welcome, 
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        !</h1>
    <asp:ListBox ID="ListBox1" runat="server" Height="293px" Width="154px"></asp:ListBox>
    <asp:Button ID="Button1" runat="server" Text="Download in XML" OnClick="Button1_Click" />
    </asp:Content>

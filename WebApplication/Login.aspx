<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Log in.aspx.cs" Inherits="WebApplication.Log_in" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content">
							<h1>Iniciar sesión</h1>
							<div class="row">
								<div class="col medium-7">
									<form id="login-form" class="form" action="/eac/login.htm" method="post">
							<div class="form_row">
								<label class="form_label" for="username">Nombre de usuario</label>&nbsp;
                                <asp:TextBox ID="usernameTextBox" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
							</div>
							<div class="form_row">
							<label class="form_label" for="password">Contraseña</label>&nbsp;
                                <asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox>
										</div>
										<div class="form_row">
                                            <asp:Button ID="Button1" CssClass="button" type="submit" runat="server" Text="Log in" OnClick="Button1_Click" />
										</div>
									</form>
								</div>
							</div>
						</div>
					</div>
				</div>
			</section>
</asp:Content>

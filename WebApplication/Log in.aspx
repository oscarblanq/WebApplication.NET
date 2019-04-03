<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Log in.aspx.cs" Inherits="WebApplication.Log_in" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content">
							<h1>Iniciar sesión</h1>
							<div class="row">
								<div class="col medium-7">
									<form id="login-form" class="form" action="/eac/login.htm" method="post">
							<div class="form_row">
								<label class="form_label" for="username">Nombre de usuario</label>
                                <input id="Text1" type="text" name="username class=form_input form_input--fullWidth" title="username"/>
							</div>
							<div class="form_row">
							<label class="form_label" for="password">Contraseña</label>
											<input id="password" name="password" class="form_input form_input--fullWidth" title="Password" type="password" value="" maxlength="255"/>
										</div>
										<div class="form_row">
                                            <asp:Button ID="Button1" CssClass="button" type="submit" runat="server" Text="Log in" />
										</div>
									</form>
								</div>
							</div>
						</div>
					</div>
				</div>
			</section>
</asp:Content>

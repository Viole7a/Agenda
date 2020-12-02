<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="Agenda.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:bundlereference runat="server" path="~/Content/css" />
</head>
<body>   
    <form id="form1" runat="server">
    <div class="grid" >
        <div class="centered grid__col--4">                                   
            <h2 class="headline-secondary--grouped">Minha Agenda</h2>                       
                
            <div>
                <div class="form-group">
                    <h6>
                        <asp:Label id="txtMensagem" Text="" Visible="false" runat="server" class="grid__col--12 msg-warming" autosize="true" />    
                    </h6>
                </div>
                <div class="form-group">
                    <label>Login: </label>
                    <asp:TextBox id="txtLogin" runat="server" class="form__input"/>
                </div>                                                
                <div class="form-group">
                    <label>Senha: </label>
                    <asp:TextBox ID="txtSenha" TextMode="Password" runat="server" class="form__input" />
                </div>                                                
                <div class="form-group">                        
                    <asp:Button ID="btnEntrar" Text="Entrar" runat="server" class="btn--default" />
                    <asp:Button ID="btnCadastrar" Text="Cadastrar" runat="server" class="btn--default" />
                </div>        
            </div>
        </div>
    </div>
    </form>
</body>
</html>

<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Cadastrar.aspx.vb" Inherits="Agenda.WebForm2" %>

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
                <h2 class="headline-secondary--grouped">Cadastrar</h2>
                <div class="form-group">
                    <h6>
                        <asp:Label id="txtMensagem" Text="" Visible="false" runat="server" class="grid__col--12 msg-warming" autosize="true" />    
                    </h6>
                </div>
                <div>
                    <div class="form-group">
                        <label>Nome: </label>
                        <asp:TextBox id="txtNome" runat="server" class="form__input"/>
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
                        <asp:Button ID="btnCadastrar" Text="Cadastrar" runat="server" class="btn--default" />
                        <asp:Button ID="btnVoltar" Text="Voltar" runat="server" class="btn--default" />
                    </div>                        
                </div>
            </div>
        </div>
    </form>
</body>
</html>

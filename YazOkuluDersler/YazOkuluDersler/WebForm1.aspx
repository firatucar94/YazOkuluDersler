<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="YazOkuluDersler.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">

        <div class="form-group">

            <div>
                <strong>
                <asp:Label for="TextBox1" runat="server" Text="Öğrenci Adı :"></asp:Label>
                </strong>
                <asp:TextBox ID="txtOgrAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TextBox2" runat="server" Text="Öğrenci Soyadı :"></asp:Label>
                </strong>
                <asp:TextBox ID="txtOgrSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
             <br />
            <div>
                <strong>
                <asp:Label for="TextBox3" runat="server" Text="Öğrenci Numarası :"></asp:Label>
                </strong>
                <asp:TextBox ID="txtOgrNo" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
             <br />
            <div>
                <strong>
                <asp:Label for="TextBox4" runat="server" Text="Şifre :"></asp:Label>
                </strong>
                <asp:TextBox ID="txtOgrSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
             <br />
            <div>
                <strong>
                <asp:Label for="TextBox5" runat="server" Text="Öğrenci Fotoğrafı :"></asp:Label>
                </strong>
                <asp:TextBox ID="txtOgrFoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        </div>

        <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" CssClass="btn btn-info" />

    </form>

</asp:Content>

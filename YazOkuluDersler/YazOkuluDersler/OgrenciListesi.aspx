<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="YazOkuluDersler.OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci ID</th>
            <th>Öğrenci Ad</th>
            <th>Öğrenci Soyad</th>
            <th>Öğrenci Numara</th>
            <th>Öğrenci Şifre</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Bakiye</th>
            <th>İslemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("OgrId") %></td>
                        <td><%#Eval("OgrAd") %></td>
                        <td><%#Eval("OgrSoyad") %></td>
                        <td><%#Eval("OgrNumara") %></td>
                        <td><%#Eval("OgrSifre") %></td>
                        <td><%#Eval("OgrFoto") %></td>
                        <td><%#Eval("OgrBakiye") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"~/OgrSil.aspx?OgrId="+Eval("OgrId")  %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#"~/OgrGuncelle.aspx?OgrId="+Eval("OgrId")  %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="kduzenle.aspx.cs" Inherits="ertevproje.kduzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid mt-5 pt-3">
        <div class="container">
            <div class="row">
                <div class="col-lg-8">
                    <div class="mb-2 p-1" id="bilgi" runat="server" style="font-size:20px; color:black; width:100%;" ></div>
                    <div class="section-title mb-0">
                        <h4 class="m-0 text-uppercase font-weight-bold">Kullanıcı Düzenle</h4>
                    </div>
                    <div class="alert-warning mb-2 p-1" id="tblist" runat="server" ></div>
                </div>
            </div>
        </div>
</asp:Content>

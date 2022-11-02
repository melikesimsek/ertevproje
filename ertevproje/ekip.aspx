<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ekip.aspx.cs" Inherits="ertevproje.ekip" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container-fluid mt-5 pt-3">
            <div class="row">
                <div class="col-lg-12">
                    <div class="mb-2  p-1" id="bilgi" runat="server" style=" font-size:20px; color:black; width:100%;" ></div>
                    <div class="section-title mb-0">
                        <h4 class="m-0 text-uppercase font-weight-bold">Ekibimiz</h4>
                    </div>
                    <div class="table table-bordered table-hover mt-3" id="perlist" runat="server" ></div>
                </div>
            </div>
        </div>
    </asp:Content>

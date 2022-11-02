<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="kguncelle.aspx.cs" Inherits="ertevproje.kguncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid mt-5 pt-3">
        <div class="container">
            <div class="row">
                <div class="col-lg-8">
                    <div class="mb-2 p-1" id="bilgi" runat="server" style="font-size:20px; color:black; width:100%;" ></div>
                    <div class="section-title mb-0">
                        <h4 class="m-0 text-uppercase font-weight-bold">Kullanıcı Güncelle</h4>
                    </div>
                <div class="form-row mt-3">
                    <div class="col-md-7">
                        <div class="form-group">
                            <asp:TextBox ID="TextBox1" type="text" class="form-control p-4" placeholder="Kullanıcı ID" required="required" runat="server"></asp:TextBox>
                        </div>
                    </div>
                  <div class="col-md-7">
                        <div class="form-group">
                            <asp:TextBox ID="TextBox2" type="text" class="form-control p-4" placeholder="Kullanıcı Adı" required="required" runat="server"></asp:TextBox>
                        </div>
                    </div>
           
                 <div class="col-md-7">
                        <div class="form-group">
                            <asp:TextBox ID="TextBox3" type="text" class="form-control p-4" placeholder="Şifre" required="required" runat="server"></asp:TextBox>
                        </div>
                    </div>
                        </div>
                     <div class="col-xl-12">
                         <div class="form-group">
                             <asp:Button ID="Button1" class="btn btn-primary font-weight-semi-bold px-4"  style="height:50px;" runat="server" Text="Güncelle" OnClick="Button1_Click"/>
                            </div>
                       </div>
                </div>
            </div>
        </div>
        
</asp:Content>

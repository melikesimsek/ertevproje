<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="eekle.aspx.cs" Inherits="ertevproje.eekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid mt-5 pt-3">
        <div class="container">
            <div class="row">
                <div class="col-lg-8">
                    <div class="mb-2 p-1" id="bilgi" runat="server" style="font-size:20px; color:black; width:100%;" ></div>
                    <div class="section-title mb-0">
                        <h4 class="m-0 text-uppercase font-weight-bold">Eğitim Ekle</h4>
                    </div>
                <div class="form-row mt-3">
                    <div class="col-md-7">
                        <div class="form-group">
                            <asp:Label ID="Label9" runat="server" Text="No"></asp:Label>
                            <asp:TextBox ID="TextBox1" type="text" class="form-control p-4" placeholder="Eğitim No" required="required" runat="server"></asp:TextBox>
                        </div>
                    </div>
                  <div class="col-md-7">
                        <div class="form-group">
                            <asp:Label ID="Label8" runat="server" Text="Kurs Adı "></asp:Label>
                            <asp:DropDownList ID="DropDownList3" runat="server">
                                <asp:ListItem Value="1">CNC Operatörlüğü</asp:ListItem>
                                <asp:ListItem Value="2">PLC Sistemleri</asp:ListItem>
                                <asp:ListItem Value="3">Web Tasarımı</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                     <div class="col-md-7">
                   <div class="form-group">
                       <asp:Label ID="Label6" runat="server" Text="Süre/Saat"></asp:Label>
                   <asp:TextBox ID="TextBox4" class="form-control p-4" required="required" runat="server" Placeholder="400" TextMode="SingleLine"></asp:TextBox>
                   </div>
                 </div>
                     <div class="col-md-7">
                   <div class="form-group">
                       <asp:Label ID="Label3" runat="server" Text="Kontenjan"></asp:Label>
                   <asp:TextBox ID="TextBox5" class="form-control p-4" required="required" runat="server" Placeholder="20" TextMode="SingleLine"></asp:TextBox>
                   </div>
                 </div>
                    <div class="col-md-7">
                   <div class="form-group">
                       <asp:Label ID="Label1" runat="server" Text="Başlangıç Tarihi"></asp:Label>
                   <asp:TextBox ID="TextBox3" class="form-control p-4" required="required" runat="server" TextMode="Date"></asp:TextBox>
                   </div>
                 </div>
                    <div class="col-md-7">
                   <div class="form-group">
                       <asp:Label ID="Label2" runat="server" Text="Bitiş Tarihi Tarihi"></asp:Label>
                   <asp:TextBox ID="TextBox7" class="form-control p-4" required="required" runat="server" TextMode="Date"></asp:TextBox>
                   </div>
                 </div>
                 <div class="col-md-7">
                        <div class="form-group">
                            <asp:Label ID="Label5" runat="server" Text="İçerik"></asp:Label>
                            <asp:TextBox ID="TextBox6" type="text" class="form-control p-4" placeholder="Kurs hakkında bilgi" required="required" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </div>
                     <div class="col-xl-12">
                         <div class="form-group">
                          
                             <asp:Button ID="Button1" class="btn btn-primary font-weight-semi-bold px-4"  style="height:50px;" runat="server" Text="Ekle" OnClick="Button1_Click"/>
                            </div>
                       </div>
                </div>
            </div>
        </div>
</asp:Content>

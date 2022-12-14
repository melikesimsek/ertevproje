<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="basvuru.aspx.cs" Inherits="ertevproje.basvuru" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid mt-5 pt-3">
        <div class="container">
            <div class="row">
                <div class="col-lg-8">
                    <div class="mb-2 p-1" id="bilgi" runat="server" style="font-size:20px; color:black; width:100%;" ></div>
                    <div class="section-title mb-0">
                        <h4 class="m-0 text-uppercase font-weight-bold">Başvuru Formu</h4>
                    </div>
                <div class="form-row mt-3">
                    <div class="col-md-7">
                        <div class="form-group">
                            <asp:Label ID="Label9" runat="server" Text="Ad"></asp:Label>
                            <asp:TextBox ID="TextBox1" type="text" class="form-control p-4" placeholder="Ad" required="required" runat="server"></asp:TextBox>
                        </div>
                    </div>
                  <div class="col-md-7">
                        <div class="form-group">
                            <asp:Label ID="Label8" runat="server" Text="Soyad"></asp:Label>
                            <asp:TextBox ID="TextBox2" type="text" class="form-control p-4" placeholder="Soyad" required="required" runat="server"></asp:TextBox>
                        </div>
                    </div>
                      <div class="col-md-7">
                          <asp:Label ID="Label7" runat="server" Text="Cinsiyet"></asp:Label>
                        <div class="form-group" CssClass="form-control p-4" style="background-color:white; padding:10px; margin-top:5px; border: 1px solid #ced4da;">
                            <asp:RadioButton  ID="RadioButton1" runat="server" GroupName="cins" Text="Kadın" Checked="True"  style="margin-left:10px;"/>
                            <asp:RadioButton  ID="RadioButton2" runat="server" GroupName="cins" Text="Erkek" style="margin-left:10px;"/>
                        </div>
                    
                    </div>
                    <div class="col-md-7">
                   <div class="form-group">
                       <asp:Label ID="Label1" runat="server" Text="Doğum Tarihi"></asp:Label>
                   <asp:TextBox ID="TextBox3" class="form-control p-4" required="required" runat="server" TextMode="Date"></asp:TextBox>
                   </div>
                 </div>
                    <div class="col-md-7">
                        <div class="form-group">
                       <asp:Label ID="Label2" runat="server" Text="Doğum Yeri"></asp:Label>
                         <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="il" DataValueField="plaka">
                             <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                         </asp:DropDownList>
                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ertevegitimvt %>" SelectCommand="SELECT * FROM [sehir]"></asp:SqlDataSource>
                        </div>
                    </div>
                     <div class="col-md-7">
                   <div class="form-group">
                       <asp:Label ID="Label6" runat="server" Text="Cep Telefonu"></asp:Label>
                   <asp:TextBox ID="TextBox4" class="form-control p-4" required="required" runat="server" Placeholder="05xxxxxxxxx" TextMode="Phone"></asp:TextBox>
                   </div>
                 </div>
                     <div class="col-md-7">
                   <div class="form-group">
                       <asp:Label ID="Label3" runat="server" Text="E- Posta"></asp:Label>
                   <asp:TextBox ID="TextBox5" class="form-control p-4" required="required" runat="server" Placeholder="example@mail.com" TextMode="Email"></asp:TextBox>
                   </div>
                 </div>
                 <div class="col-md-7">
                        <div class="form-group">
                            <asp:Label ID="Label5" runat="server" Text="Adres"></asp:Label>
                            <asp:TextBox ID="TextBox6" type="text" class="form-control p-4" placeholder="Adres" required="required" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </div>
                       <div class="col-md-7">
                        <div class="form-group">
                             <asp:Label ID="Label4" runat="server" Text="Katıldığı Eğitim"></asp:Label>
                            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="kurs_adi" DataValueField="kurs_no"></asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ertevegitimvt %>" SelectCommand="SELECT [kurs_adi], [kurs_no] FROM [kurslar] WHERE [bas_tar] &gt;=GETDATE()"></asp:SqlDataSource>
                        </div>
                    </div>
                     
                     <div class="col-xl-12">
                         <div class="form-group">
                          
                             <asp:Button ID="Button1" class="btn btn-primary font-weight-semi-bold px-4"  style="height:50px;" runat="server" Text="Başvur" OnClick="Button1_Click"/>
                            </div>
                       </div>
                </div>
            </div>
        </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication1.admin.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="card mb-4">
       <div class="card-header">
           Modifier une Formation
       </div>
       <div class="card-body">
            <div>
  <div class="form-group">
    <label for="exampleFormControlInput1">Title</label>
    <asp:Textbox runat="server" type="text" required class="form-control" id="titletext" placeholder="Titre"></asp:Textbox>
  </div>
  <div class="form-group">
    <label for="exampleFormControlInput1">Short Description</label>
    <asp:Textbox runat="server" type="text" required class="form-control" id="shortdescriptiontext" placeholder="petite Description"></asp:Textbox>
  </div>
    <div class="form-group">
    <label for="exampleFormControlInput1">Description</label>
    <asp:Textbox runat="server" type="text" required class="form-control" id="Descriptiontext" placeholder="Description"></asp:Textbox>
  </div>
   <div class="form-group">
    <label for="exampleFormControlInput1">Date début</label>
    <asp:TextBox runat="server" TextMode="Date" required class="form-control" id="dt_debut"></asp:TextBox>
  </div>
   <div class="form-group">
    <label for="exampleFormControlInput1">Date Fin</label>
    <asp:TextBox runat="server" TextMode="Date" required class="form-control" id="dt_fin"></asp:TextBox>
  </div>
   
        <div class="form-group">
            <label class="text-black-50" for="pj">Image</label>
            <asp:FileUpload ID="cr_img" runat="server" CssClass="form-control-file" />
        </div>
</div>
       </div>
       <div class="card-footer">
           <asp:Button runat="server" ID="btn_add" CssClass="btn btn-primary" Text="Modifier" OnClick="btn_add_Click" />
       </div>
   </div>
</asp:Content>

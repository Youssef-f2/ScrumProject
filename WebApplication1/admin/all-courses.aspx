<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="all-courses.aspx.cs" Inherits="WebApplication1.admin.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%if (ou.ds.Tables["allcourses"].Rows.Count > 0)
    {
         %>
    <div class="row">
        <table class="table table-striped table-hover text-center">
            <thead>
                 <tr>
                  <th scope="col">id</th>
                  <th scope="col">image</th>
                  <th scope="col">title</th>
                   <th scope="col">content</th>
                  <th scope="col">Modifier</th>
                  <th scope="col">Supprimer</th>
                </tr>
             </thead>
    <%
        for (int i = 0; i < ou.ds.Tables["allcourses"].Rows.Count; i++)
        {
            %>
        
            <tr>
                <td>
                    <%= ou.ds.Tables["allcourses"].Rows[i][0].ToString() %>
                </td>
                <td>
                   <img src="<%=ou.ds.Tables["allcourses"].Rows[i][4].ToString()%>"/>
                </td>
                <td>
                    <%= ou.ds.Tables["allcourses"].Rows[i][1].ToString() %>
                </td>
                <td>
                    <%= ou.ds.Tables["allcourses"].Rows[i][2].ToString() %>
                </td>
                <td>
                      <a href="<%=ResolveUrl("~/admin/edit.aspx?id="+ou.ds.Tables["allcourses"].Rows[i][0].ToString()) %>" class="btn btn-sm btn-primary">Modifier</a>

                </td>
                <td>
                    <a href="<%=ResolveUrl("~/Controller/action.aspx?do=delete&id="+ou.ds.Tables["allcourses"].Rows[i][0].ToString()) %>" class="btn btn-sm btn-danger">Supprimer</a>
                </td>
            </tr>  
            

        <%}%>
        </table>
        </div>
    <%
    }
    else
    { %>
            <div class="alert alert-primary" role="alert">
              Aucun course trouve pour instant !
            </div>
    <%} %>
</asp:Content>

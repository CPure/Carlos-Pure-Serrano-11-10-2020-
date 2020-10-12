<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Bertoni.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th>
                        <asp:DropDownList ID="cmbAlbum"  datatextfield="title"      datavaluefield="id" runat="server"></asp:DropDownList>
                    </th>
                    <th>
                        <asp:Button ID="btnVisual" runat="server" Text="Visualizar Album" OnClick="btnVisual_Click" />
                    </th>
                </tr>
            </table>
            
            <asp:GridView ID="grdPhoto" runat="server" AutoGenerateColumns="false" OnRowCommand="grdPhoto_RowCommand" >
                <Columns>
                     <asp:TemplateField HeaderText="Image">
                        <ItemTemplate>
                             <asp:Image ID="img1" runat="server" ImageUrl='<%# Eval("thumbnailUrl") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Title">
                        <ItemTemplate>
                            <asp:Label ID="lblTitle" runat="server" Text='<% #Bind("title") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Title">
                        <ItemTemplate>
                            <asp:Button Text="Ver Comentarios"  runat="server" CommandArgument="<%# Container.DataItemIndex %>"   />
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>
            <asp:GridView ID="grdComments" runat="server" AutoGenerateColumns="false" >
                <Columns>
                     
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="server" Text='<% #Bind("name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Email">
                        <ItemTemplate>
                            <asp:Label ID="lblEmail" runat="server" Text='<% #Bind("email") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Body">
                        <ItemTemplate>
                            <asp:Label ID="lblBody" runat="server" Text='<% #Bind("body") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>

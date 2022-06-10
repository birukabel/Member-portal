<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ECX.ECXInterface.UI.Login" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <title>Login</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="icon" type="image/png" href="Images/ECXLogo.png">
    <link href="lib/bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="lib/fonts/font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet" />
    <link href="lib/bootstrap/css/util.css" rel="stylesheet" />
     <link href="lib/bootstrap/css/main.css" rel="stylesheet" />
</head>
<body>
    <div class="container-login100" style="background-image: url('images/ecx_trade_floor.jpg');">
        <div class="wrap-login100 ">
            <form class="login100-form" runat="server">
                <div class="login100-form-avatar">
                    <img src="Images/ECXLogo.png" alt="AVATAR"/>
                </div>

                <span class="login100-form-title p-t-20 p-b-45">
                    <h2>Member Interface Application</h2>
                </span>

                <div class="wrap-input100 validate-input m-b-10" data-validate="Username is required">
                    <asp:TextBox ID="txtUserName" runat="server" class="input100"  placeholder="Username" pattern="([M]).([0-9]).{2,8}"
                        title="Must start with letter M followed by more than 4 digit numbers.."
                         required="required"/>
                    <span class="focus-input100"></span>
                    <span class="symbol-input100">
                        <i class="fa fa-user"></i>
                    </span>
                    <span ></span>
                </div>

                <div class="wrap-input100 validate-input m-b-10" data-validate="Password is required">
                    <asp:TextBox ID="txtPassword" runat="server" class=" input100" type="password"  placeholder="Password" required ="required"/>
                    <span class="focus-input100"></span>
                    <span class="symbol-input100">
                        <i class="fa fa-lock"></i>
                    </span>
                    <asp:Label ID="lblError" runat="server" CssClass="m-b-10" ForeColor="#ea0000" />
                </div>
                <asp:Label ID="lblNotification" runat="server" ></asp:Label>
                <div class="container-login100-form-btn p-t-10">
                     <asp:Button ID="btnSubmit" runat="server" Text="Login" CssClass="login100-form-btn" OnClick="LogIn" />
                </div>
            </form>
        </div>
    </div>
</body>
</html>
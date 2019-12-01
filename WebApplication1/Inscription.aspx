<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inscription.aspx.cs" Inherits="WebApplication1.Connexion" ValidateRequest="false" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/iconic/css/material-design-iconic-font.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animate/animate.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animsition/css/animsition.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/daterangepicker/daterangepicker.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css/util.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
<!--===============================================================================================-->
<script src="JavaScript.js" type="text/javascript"></script>
<script>    
	function bad() {
		Swal.fire({
			icon: 'error',
			title: 'Oops...',
			text: 'le login exist déja!'
		})
	}
	function pass() {
		Swal.fire({
			icon: 'error',
			title: 'Oops...',
			text: 'mot de passe incorrect!'
		})
	}
</script>
</head>
<body>
    <form id="form1" runat="server">
   <div class="limiter">
		<div class="container-login100" style="background-image: url('images/bg-01.jpg');">
			<div class="wrap-login100 p-l-55 p-r-55 p-t-65 p-b-54">
				<div class="login100-form validate-form">
					<span class="login100-form-title p-b-49">
						Inscription
					</span>

					<div class="wrap-input100 validate-input m-b-23" >
						<span class="label-input100">Login</span>
						<asp:textBox class="input100" required runat="server" type="text" name="login" id="login" placeholder="Login"></asp:textBox>
						<span class="focus-input100" data-symbol="&#xf206;"></span>
					</div>

					<div class="wrap-input100 validate-input m-b-23">
						<span class="label-input100">Nom</span>
						<asp:textBox class="input100" required runat="server" type="text" name="name" id="name" placeholder="Nom"></asp:textBox>
						<span class="focus-input100" data-symbol="&#xf206;"></span>
					</div>

					<div class="wrap-input100 validate-input m-b-23" >
						<span class="label-input100">Prénom</span>
						<asp:textBox class="input100" required runat="server" type="text" name="prénom" id="prénom" placeholder="Prénom"></asp:textBox>
						<span class="focus-input100" data-symbol="&#xf206;"></span>
					</div>

					<div class="wrap-input100 validate-input m-b-23">
						<span class="label-input100">EMAIL</span>
						<asp:textBox class="input100" required runat="server" type="email" name="email" id="email" placeholder="Email"></asp:textBox>
						<span class="focus-input100" data-symbol="&#xf2c2;"></span>
					</div>

					<div class="wrap-input100 validate-input m-b-23">
						<span class="label-input100">Mot de Passe</span>
						<asp:textBox class="input100" required runat="server" type="password" name="pass" id="pass" placeholder="Mot de Passe"></asp:textBox>
						<span class="focus-input100" data-symbol="&#xf190;"></span>
					</div>

					<div class="wrap-input100 validate-input">
						<span class="label-input100">Répeter le Mot de Passe</span>
						<asp:textBox class="input100" required runat="server"  type="password" name="re_pass" id="re_pass" placeholder="Répeter votre mot de passe"></asp:textBox>
						<span class="focus-input100" data-symbol="&#xf190;"></span>
					</div>

					
					
					<div class="text-right p-t-8 p-b-31">
						
					</div>
					
					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
							<asp:button class="login100-form-btn" runat="server" Id="btn_signup" OnClick="btn_signup_Click" Text="S'inscrire"/>
								
						</div>
					</div>

					<div class="flex-col-c p-t-155">
						<a href="Connexion.aspx" class="txt2">
							 Se Connecter
						</a>
					</div>
				</div>
			</div>
		</div>
	</div>
	

	
	
<!--===============================================================================================-->
	<script src="vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/bootstrap/js/popper.js"></script>
	<script src="vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/daterangepicker/moment.min.js"></script>
	<script src="vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
	<script src="vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	<script src="js/main.js"></script>
    </form>
</body>
</html>

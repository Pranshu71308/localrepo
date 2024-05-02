@model Amnex_Project_Resource_Mapping_System.Models.Login
@{ 
    Layout = null; 
    }
<head>
    <title>Your Website Title</title>
    <script src="~/lib/jquery/dist/jquery.min.js"></script>
    <script src="~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"></script>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src="https://www.google.com/recaptcha/api.js"></script>
    <style>
        .main-container {
            height: 100vh;
            width: 100vw;
            background: url('../assets/images/bg.jpg');
            color: white;
            background-repeat: no-repeat;
            background-size: cover;
        }

        .login-modal {
            color: black !important;
        }
        .password-wrapper {
            position: relative;
        }

        .password-toggle {
            position: absolute;
            top: 50%;
            right: 10px;
            transform: translateY(-50%);
            cursor: pointer;
            width: 20px;
            height: 20px;
        }
    </style>
</head>
<div class="container-fluid d-flex justify-content-center align-items-center flex-column main-container text-center">
    <img style="height:10rem;" src="~/assets/images/prms-logo.png" />
    <h1>Welcome to PRMS</h1>
    @*     <p>Efficiently manage and allocate company resources <br />with our Project Resource Mapping System.<br /> Track current allocations and easily adjust as per project requirements.</p>
    *@
    <p>
        Efficiently map, track and allocate resource to the required project.
    </p>
    <button id="loginBtnClick" class="btn btn-primary" data-bs-toggle="modal" data-target="#loginModal">Get Started</button>

</div>
@* login-modal *@

<div class="modal fade" id="loginModal" tabindex="-1" role="dialog" aria-labelledby="loginModalLabel" aria-hidden="true">
    <div class="modal-dialog modal-dialog-centered" role="document">
        <div class="modal-content">
            <div class="container-fluid">
                <div class="bg-light rounded h-100 p-4 login-modal">
                    <h3 class="text-center">Admin Login</h3>
                    <p class="mb-4 text-center">We need to verify you before getting started!</p>
                    <form id="login-form" asp-controller="Account" asp-action="Login" method="post">
                        @*<div asp-validation-summary="ModelOnly" class="text-danger"></div>*@
                        <div class="mb-3 form-group">
                            <label asp-for="Username" class="control-label">User Name</label>
                            <input asp-for="Username" class="form-control" id="Username" />
                            @*<span asp-validation-for="Username" class="text-danger"></span>*@
                        </div>
                        <div class="mb-1 form-group">
                            <label asp-for="Password" class="control-label">Password</label>
                            <div class="password-wrapper">
                                <input type="password" asp-for="Password" class="form-control" id="Password" autocomplete="off">
                                <div class="password-toggle" id="togglePassword">
                                    <!-- Embedding SVG directly -->
                                    <svg viewBox="0 0 576 512" height="1em" xmlns="http://www.w3.org/2000/svg">
                                        <path d="M288 32c-80.8 0-145.5 36.8-192.6 80.6C48.6 156 17.3 208 2.5 243.7c-3.3 7.9-3.3 16.7 0 24.6C17.3 304 48.6 356 95.4 399.4C142.5 443.2 207.2 480 288 480s145.5-36.8 192.6-80.6c46.8-43.5 78.1-95.4 93-131.1c3.3-7.9 3.3-16.7 0-24.6c-14.9-35.7-46.2-87.7-93-131.1C433.5 68.8 368.8 32 288 32zM144 256a144 144 0 1 1 288 0 144 144 0 1 1 -288 0zm144-64c0 35.3-28.7 64-64 64c-7.1 0-13.9-1.2-20.3-3.3c-5.5-1.8-11.9 1.6-11.7 7.4c.3 6.9 1.3 13.8 3.2 20.7c13.7 51.2 66.4 81.6 117.6 67.9s81.6-66.4 67.9-117.6c-11.1-41.5-47.8-69.4-88.6-71.1c-5.8-.2-9.2 6.1-7.4 11.7c2.1 6.4 3.3 13.2 3.3 20.3z"></path>
                                    </svg>
                                </div>
                            </div>
                            @*<span asp-validation-for="Password" class="text-danger"></span>*@
                        </div>
                        <div class="g-recaptcha" data-sitekey="6LcSucopAAAAACsXl5tF2aN27baH9gpcKSLOFlii"></div>
                        <div id="error-message" class="text-danger"></div> <!-- Display error messages here -->
                        <div class="text-end mb-3 form-group">Forgot Password ?</div>
                        <div class="d-flex justify-content-center">
                            <div id="Errormsg" class="text-danger">

                            </div>
                        </div>
                        <div class="form-group">
                            <input type="button" id="loginbtn" value="submit" class=" g-recaptcha btn btn-primary px-5 text-center w-100 mt-3" data-sitekey="6Ld_ncopAAAAANS4se8emFQf_kHtjImaZkhe9XYp" data-callback='onSubmit' />
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>

<script src="~/lib/jquery/dist/jquery.min.js"></script>
<script src="~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js"></script>


<script>
    $(document).ready(function () {
        $(document).ready(function () {
            $('#togglePassword').click(function () {
                var passwordInput = $('#Password');
                var passwordFieldType = passwordInput.attr('type');
                var newPasswordFieldType = (passwordFieldType === 'password') ? 'text' : 'password';
                passwordInput.attr('type', newPasswordFieldType);
            });
        });
        $("#loginBtnClick").click(function () {
            $("#loginModal").modal('show');
        });

        $('#loginbtn').click(function (e) {
            e.preventDefault();

            var username = $('#Username').val();
            var password = $('#Password').val();
            var recaptchaResponse = $('#g-recaptcha-response').val(); // Assuming you have a hidden input field with id 'g-recaptcha-response' to store the CAPTCHA response
            if (username.length < 1 & password.length < 1) {
                $('#Errormsg').text("Enter Username and password");
                return;
            }
            if (password.length < 1) {
                $('#Errormsg').text("Enter password");
                return;
            }
            if (username.length < 1) {
                $('#Errormsg').text("Enter Username");
                return;
            }

            // Perform basic client-side validation
            if (!username.trim() || !password.trim()) {
                $('#Username').next('.text-danger').text('Please enter a username.');
                $('#Password').next('.text-danger').text('Please enter a Password.'); return;
            }

            // Send AJAX request
            $.ajax({
                type: 'POST',
                url: '/Account/Login',
                data: {
                    username: username,
                    password: password,
                    recaptchaResponse: recaptchaResponse
                },
                success: function (response) {
                    if (response.success) {
                        // Redirect to dashboard
                        window.location.href = '/Home/Dashboard';
                    } else {
                        $('#Errormsg').text(response.message);
                        $('#Username').val('')
                        $('#Password').val('')
                        grecaptcha.reset();
                        return;
                    }
                },
                error: function () {
                    alert('An error occurred. Please try again.');
                }
            });
        });
    });
</script>

@section Scripts {
    @{
        await Html.RenderPartialAsync("_ValidationScriptspartial");
    }
}

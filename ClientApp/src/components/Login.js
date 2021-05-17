import React, { Component } from 'react';

export class Login extends Component {
	static displayName = Login.name;

	render() {
		return (
			<div>
				<body>
					<div class="login-wrap">
						<div class="login-html">
							<input id="tab-1" type="radio" name="tab" class="sign-in" checked /><label for="tab-1" class="tab">Logga in</label>
							<input id="tab-2" type="radio" name="tab" class="sign-up" /><label for="tab-2" class="tab">Skapa konto</label>
							<input id="tab-3" type="radio" name="tab" class="forgot-password" /><label for="tab-3" class="tab"></label>
							<div class="login-form">
								<div class="sign-in-htm">
									<div class="group">
										<label for="user" class="label">Användarnamn</label>
										<input id="user" type="text" class="input" />
									</div>
									<div class="group">
										<label for="pass" class="label">Lösenord</label>
										<input id="pass" type="password" class="input" data-type="password" />
									</div>
									<div class="group">
										<input id="check" type="checkbox" class="check" checked />
										<label for="check"><span class="icon"></span> Håll mig Inloggad</label>
									</div>
									<div class="group">
										<input type="submit" class="button" value="Logga In" />
									</div>
									<div class="hr"></div>
									<div class="foot-lnk">
										<label for="tab-3">Glömt Lösenord?</label>
									</div>
								</div>
								<div class="sign-up-htm">
									<div class="group">
										<label for="user" class="label">Användarnamn</label>
										<input id="user" type="text" class="input" />
									</div>
									<div class="group">
										<label for="pass" class="label">Lösenord</label>
										<input id="pass" type="password" class="input" data-type="password" />
									</div>
									<div class="group">
										<label for="pass" class="label">Upprepa Lösenord</label>
										<input id="pass" type="password" class="input" data-type="password" />
									</div>
									<div class="group">
										<label for="email1" class="label">Email Adress</label>
										<input id="email1" type="text" class="input" />
									</div>
									<div class="group">
										<input type="submit" class="button" value="Logga In" />
									</div>
								</div>
								<div class="forgot-password-htm">
									<div class="group">
										<label for="email2" class="label">Email</label>
										<input id="email2" type="email" class="input" />
									</div>
									<div class="group">
										<input type="submit" class="button" value="Återställ Lösenord" />
									</div>
								</div>
							</div>
						</div>
					</div>
				</body>
			</div>
		);
	}
}
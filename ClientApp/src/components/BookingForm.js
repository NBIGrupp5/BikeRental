import React, { Component } from 'react';
import './BookingForm.css'

export class BookingForm extends Component {
  static displayName = BookingForm.name;

  render() {
    return (
      <div>
				<body>
					<div class="dininfo-wrap">
						<div class="login-html">
							<input id="tab-1" type="radio" name="tab" class="sign-in" checked /><label for="tab-1" class="tab">Din information</label>

							<div class="login-form">
								<div class="sign-in-htm">
									<div class="group">
										<label for="fname" className="text">Förnamn</label>
										<input type="text" id="fname" name="firstname" placeholder="Your name.." />
									</div>
									<div class="group">
										<label for="lname" className="text">Efternamn</label>
										<input type="text" id="lname" name="lastname" placeholder="Your last name.." />
									</div>
									<div class="group">
										<label for="phone" className="text">Mobilnummer</label>
										<input type="tel" id="text" name="tel" placeholder="0XX XXX-XX-XX" />
									</div>
									<div class="group">
										<label for="email" className="text">Email</label>
										<input type="email" id="email" name="email" placeholder="mail@mail.com" />
									</div>
									<div>
										<label for="cykeltyp" className="text">Cykeltyp</label><br />
										<select className="cykel" id="cykeltyp" name="cykeltyp">
											<option value="Mountainbike" className="others">Mountainbike</option>
											<option value="Elcykel" className="others">Elcykel</option>
											<option value="Stadscykel" className="others">Stadscykel</option>
										</select>
									</div>
									<div class="group">
										<label for="antal" className="text">Antal</label>
										<input type="number" id="antal" name="antal" /><br />
									</div>
									<div class="group">
										<label for="rent" className="text">Hyras från:</label>
										<input type="date" id="rent" name="rent" />
									</div>
									<div class="group">
										<label for="lämnar" className="text">Inlämningsdatum: </label><br />
										<input type="date" id="dropdate" name="dropdate" value />
									</div>
									<div class="group">
										<label for="confirmation" className="text-white" >Skicka bekräftelse via mail </label>
										<input type="checkbox" id="email" name="email" value="" /><br />
									</div>
									<div class="group">
										<label for="confirmation" className="text-white" >Skicka bekräftelse via SMS </label>
										<input type="checkbox" id="email" name="email" value="" /><br />

										<div class="group">
											<input type="submit" id="submit" name="Submit" value="Boka" />
										</div>
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
import React, { Component, useState } from 'react';
import './BookingForm.css'
import Accordion from 'react-bootstrap/Accordion'
import { Link } from 'react-router-dom';




export class BookingForm extends Component {
  static displayName = BookingForm.name;




  constructor(props) {
    super(props);
    console.log(props)
    this.state = {
      biketype: props.location.state.biketype

    }
  }



  render() {
    return (
      <div>
        <body>



          <h2>Din bokning</h2>



          {/*<!-- Tid och datum för denna beställning -->*/}
          <p id="date"></p>
          <script>
            document.getElementById("date").innerHTML = Date();
</script>



          <div class="row">
            <div class="col-75">
              <div class="container">
                <form action="/action_page.php">



                  <div class="row">
                    <div class="col-50">
                      <h3>Dina uppgifter</h3>
                      <label for="fname">För och efternamn</label>
                      <input type="text" id="fname" name="firstname" placeholder="Namn efternamn"></input>
                      <label for="mobil">Telefonnummer </label>
                      <input type="text" id="mobil" name="mobil" placeholder="0700 00 00 00"></input>
                      <label for="email"> E-post</label>
                      <input type="text" id="email" name="email" placeholder="din@mejl.com"></input>
                      <label for="adr"> Postadress</label>
                      <input type="text" id="adr" name="address" placeholder="Adress"></input>
                      <label for="city"> Stad</label>
                      <input type="text" id="city" name="city" placeholder="Stad"></input>
                      <label for="zip">Postnummer </label>
                      <input type="text" id="zip" name="zip" placeholder="xxx xx"></input>
                    </div>





                    <div class="col-50">
                      <h3>Betalsätt</h3>
                      <label for="fname">Våra betalningsalternativ</label>




                      <Accordion defaultActiveKey="0">
                        <Accordion.Toggle className="paybox" eventKey="0">
                          Kort
</Accordion.Toggle>
                        <Accordion.Collapse eventKey="0">
                          <div className="paycontent">
                            <p><label for="cname">Namn på kortet</label>
                              <input type="text" id="cname" name="cardname" placeholder="Pernilla Wahlgren"></input>
                              <label for="ccnum">Kortnummer </label>
                              <input type="text" id="ccnum" name="cardnumber" placeholder="1111-2222-3333-4444"></input>
                              <label for="expmonth">Exp Month</label>
                              <input type="text" id="expmonth" name="expmonth" placeholder="Månad"></input>
                              <div class="row">
                                <div class="col-50">
                                  <label for="expyear">Exp Year</label>
                                  <input type="text" id="expyear" name="expyear" placeholder="2018"></input>
                                </div>
                                <div class="col-50">
                                  <label for="cvv">CVV</label>
                                  <input type="text" id="cvv" name="cvv" placeholder="352"></input>
                                </div>
                              </div></p>
                            <Link to={{ pathname: 'BookingConfirmation' }}>
                            <input type="submit" value="Slutför bokning" class="btn"></input></Link>

                          </div>
                        </Accordion.Collapse>
                        <br></br>
                        <Accordion.Toggle className="paybox" eventKey="1">
                          Faktura
</Accordion.Toggle>
                        <Accordion.Collapse eventKey="1">
                          <div className="paycontent"><p><h6>Betala inom 14 dagar</h6></p>
                            <div>Avgift 0 kr</div>



                            <br></br>



                            <Link to={{ pathname: 'BookingConfirmation' }}>
                              <input type="submit" value="Slutför bokning" className="btn"></input></Link>
                          </div>
                        </Accordion.Collapse>



                        <Accordion.Toggle className="paybox" eventKey="2">
                          Swish
</Accordion.Toggle>
                        <Accordion.Collapse eventKey="2">
                          <div className="paycontent"> <p>Skicka din betalning med Swish. Du behöver Swish-appen och ett mobilt BandID för att använda det här betalsättet.</p>
                            <div>Skicka med ditt registrerade nummer till: </div>
                            <div><h3>0733 55 55 55</h3></div>
                            <br></br>
                            <Link to={{ pathname: 'BookingConfirmation' }}>
                            <input type="submit" value="Slutför bokning" className="btn"></input></Link>
                          </div>
                        </Accordion.Collapse>
                      </Accordion>



                    </div>
                  </div>



                </form>
              </div>
            </div>
            <div class="col-25">
              <div class="container">
                <h4>Vald cykel <span className="price" style={{ color: "black" }}><i class="fa fa-shopping-cart"></i></span></h4>
                <p><a href="#Bikes">{this.props.location.state.biketype.bikeTypeName}</a> <span class="price">{this.props.location.state.biketype.bikeTypePrice}SEK</span></p>
                <p>Total <span className="price" style={{ color: "black" }}><b>{this.props.location.state.biketype.bikeTypePrice}SEK</b></span></p>



              </div>
            </div>
          </div>



        </body>
      </div>
    ); {/*);*/ }



  }
}
export default BookingForm;
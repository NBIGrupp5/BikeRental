import React, { Component, useState } from 'react';
import './BookingForm.css'
import Accordion from 'react-bootstrap/Accordion'
import { Link } from 'react-router-dom'
import Button from 'react-bootstrap/Button'


export class BookingForm extends Component {
  static displayName = BookingForm.name;

  constructor(props) {
    super(props);
    this.state = {
      selectedBike: props.location.state
    };
    console.log(props.location.state);
  }


  render() {
    return (      
     <body>
        <div>
          <h2>Din bokning</h2>

          {/*<!-- Tid och datum för denna beställning -->*/}
          <p id="date"></p>
          <script>
            document.getElementById("date").innerHTML = Date();
                    </script>

          <div className="row">
            <div className="col-75">
              <div className="container">
                <form action="/action_page.php">

                  <div className="row">
                    <div className="col-50">
                      <h3>Dina uppgifter</h3>
                      <label htmlFor="fname">För och efternamn</label>
                      <input type="text" id="fname" name="firstname" placeholder="Namn efternamn"></input>
                      <label htmlFor="mobil">Telefonnummer </label>
                      <input type="text" id="mobil" name="mobil" placeholder="0700 00 00 00"></input>
                      <label htmlFor="email"> E-post</label>
                      <input type="text" id="email" name="email" placeholder="din@mejl.com"></input>
                      <label htmlFor="adr"> Postadress</label>
                      <input type="text" id="adr" name="address" placeholder="Adress"></input>
                      <label htmlFor="city"> Stad</label>
                      <input type="text" id="city" name="city" placeholder="Stad"></input>
                      <label htmlFor="zip">Postnummer </label>
                      <input type="text" id="zip" name="zip" placeholder="xxx xx"></input>
                    </div>



                    <div className="col-50">
                      <h3>Betalsätt</h3>
                      <label htmlFor="fname">Våra betalningsalternativ</label>


                      <Accordion defaultActiveKey="0">
                        <Accordion.Toggle className="paybox" eventKey="0">
                          Kort
                            </Accordion.Toggle>
                        <Accordion.Collapse eventKey="0">
                          <div className="paycontent">
                            <label htmlFor="cname">Namn på kortet</label>
                              <input type="text" id="cname" name="cardname" placeholder="Pernilla Wahlgren"></input>
                              <label htmlFor="ccnum">Kortnummer   </label>
                              <input type="text" id="ccnum" name="cardnumber" placeholder="1111-2222-3333-4444"></input>
                              <label htmlFor="expmonth">Exp Month</label>
                              <input type="text" id="expmonth" name="expmonth" placeholder="Månad"></input>
                              <div className="row">
                                <div className="col-50">
                                  <label htmlFor="expyear">Exp Year</label>
                                  <input type="text" id="expyear" name="expyear" placeholder="2018"></input>
                                </div>
                                <div className="col-50">
                                  <label htmlFor="cvv">CVV</label>
                                  <input type="text" id="cvv" name="cvv" placeholder="352"></input>
                                </div>
                            </div>
                            <Link to={{ pathname: 'BookingConfirmation' }}>
                            <input type="submit" value="Slutför bokning" className="btn"></input></Link>

                          </div>
                        </Accordion.Collapse>
                        <br></br>
                        <Accordion.Toggle className="paybox" eventKey="1">
                          Faktura
                          </Accordion.Toggle>
                        <Accordion.Collapse eventKey="1">
                          <div className="paycontent"><h6><p>Betala inom 14 dagar</p></h6>
                            <div>Avgift 0 kr</div>
                            <br></br>
                            <Link to={{ pathname: 'BookingConfirmation' }}>
                              <input type="submit" value="Slutför bokning" className="btn"></input></Link>
                          </div>
                        </Accordion.Collapse>
                        <br></br>
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
            <div className="col-25">
              <div className="container">
                <h4>Valda cyklar <span className="price" style={{ color: "black" }}><i className="fa fa-shopping-cart"></i> <b>4</b></span></h4>


                <p><a href="#">Product 1</a> <span className="price">$15</span></p>
                <p><a href="#">Product 2</a> <span className="price">$5</span></p>
                <p><a href="#">Product 3</a> <span className="price">$8</span></p>
                <p><a href="#">Product 4</a> <span className="price">$2</span></p>
                <hr></hr>
                <p>Total <span className="price" style={{ color: "black" }}><b>$30</b></span></p>

              </div>
            </div>
          </div>
        </div>
     </body>
      
    ); {/*);*/ }

  }
}
export default BookingForm;

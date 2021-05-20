import React, { Component, useState } from 'react';
import './BookingForm.css'






export class BookingForm extends Component {
    static displayName = BookingForm.name;

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



                                            <button type="button" class="collapsible"><i class="far fa-credit-card"></i>&nbsp;&nbsp;Kort</button>
                                            <div class="content">
                                                <br></br>
                                                <p><label for="cname">Namn på kortet</label>
                                                    <input type="text" id="cname" name="cardname" placeholder="Pernilla Wahlgren"></input>
                                                    <label for="ccnum">Kortnummer   </label>
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
                                                <input type="submit" value="Slutför bokning" class="btn"></input>
                                            </div>
                                            <button type="button" class="collapsible"><i class="fas fa-file-invoice-dollar"></i>&nbsp;&nbsp;Faktura</button>
                                            <div class="content">
                                                <br></br>
                                                <p><h6>Betala inom 14 dagar</h6></p>
                                                <div>Avgift 0 kr</div>
                                                <br></br>
                                                <input type="submit" value="Slutför bokning" class="btn"></input>
                                                <br></br>
                                            </div>

                                            <button type="button" class="collapsible"><i class="fas fa-sync-alt"></i>&nbsp;&nbsp;Swish</button>
                                            <div class="content">
                                                <br></br>
                                                <p>Skicka din betalning med Swish. Du behöver Swish-appen och ett mobilt BandID för att använda det här betalsättet.</p>
                                                <div>Skicka med ditt registrerade nummer till: </div>
                                                <div><h3>0733 55 55 55</h3></div>
                                                <br></br>
                                                <input type="submit" value="Slutför bokning" class="btn"></input>
                                            </div>




                                            {/*<script>*/}
                                            {/*    var coll = document.getElementsByClassName("collapsible");*/}
                                            {/*    var i;*/}

                                            {/*         for (i = 0; i < coll.length; {*/}
                                            {/*        coll[i].addEventListener("click", function () {*/}
                                            {/*            this.classList.toggle("active");*/}
                                            {/*            var content = this.nextElementSibling;*/}
                                            {/*            if (content.style.display === "block") {*/}
                                            {/*                content.style.display = "none";*/}
                                            {/*            } else {*/}
                                            {/*                content.style.display = "block";*/}
                                            {/*            }*/}
                                            {/*        })};*/}
                                            {/*</script>*/}

                                        </div>
                                    </div>

                                </form>
                            </div>
                        </div>
                        <div class="col-25">
                            <div class="container">
                                <h4>Valda cyklar <span class="price" style={{ color: "black" }}><i class="fa fa-shopping-cart"></i> <b>4</b></span></h4>
                                <p><a href="#">Product 1</a> <span class="price">$15</span></p>
                                <p><a href="#">Product 2</a> <span class="price">$5</span></p>
                                <p><a href="#">Product 3</a> <span class="price">$8</span></p>
                                <p><a href="#">Product 4</a> <span class="price">$2</span></p>
                                <hr></hr>
                                <p>Total <span class="price" style={{ color: "black" }}><b>$30</b></span></p>

                            </div>
                        </div>
                    </div>

                </body>
            </div>
        ); {/*);*/ }

    }
}
export default BookingForm;

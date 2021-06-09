import React, { Component } from 'react';
import './Skapakonto.css'

export class Skapakonto extends Component {
    static displayName = Skapakonto.name;

    render() {
        return (
            <html>
                <body>
                    <div id="id01" class="modal" />
                    <span onclick="document.getElementById('id01').style.display='none'" class="close" title="Close Modal">&times;</span>
                    <form class="modal-content" action="/action_page.php" />

                    <h1>Skapa Konto</h1>
                    <hr />
                    <label for="email"><b>Email</b></label><br />
                    <input type="text" placeholder="Skriv in Email" name="email" required />
                    <br />
                    <label for="psw"><b>Lösenord</b></label><br />
                    <input type="password" placeholder="Skriv in lösenord" name="psw" required />
                    <br />
                    <label for="psw-repeat"><b>Upprepa lösenord</b></label><br />
                    <input type="password" placeholder="Skriv in lösenord" name="psw-repeat" required />
                    <br />
                    <label />
                    <body>
                        <label/>

                        <p>Genom att skapa ett konto så accepterar du våra <a href="#" style={{ color: "dodgerblue" }}>Vilkor & Integritet</a>.</p>

                        <div class="clearfix">
                            <button type="button" onclick="document.getElementById('id01').style.display='none'" class="cancelbtn">Avbryt</button>
                            <button type="submit" class="signupbtn">Skapa Konto</button>
                        </div>
                    </body>
                </body>
            </html>
        )
    }
}
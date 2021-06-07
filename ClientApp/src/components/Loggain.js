import React, { Component } from 'react';
import './Loggain.css'

export class Loggain extends Component {
    static displayName = Loggain.name;

    render() {
        return (
            <div className="viewport" content="width=device-width, initial-scale=1">
                <div id="id01" class="modal" />
                <form className="modal-content animate" action="/action_page.php" method="post"></form>


                <body><center><img src="https://www.xxl.se/content/images/d1eae533f3e0543c65a407afb2e320ad7f1256bf-1332x540.png?auto=format&fit=crop&crop=focalpoint&fp-x=0.5&fp-y=0.5&w=1000&h=500"
                    width="400"
                    height="300" />


                    <label for="uname"><b>Användarnamn</b></label>
                    <input type="text" placeholder="Skriv in användarnamn" name="uname" required></input>
                    <br />
                    <label for="psw"><b>Lösenord</b></label>
                    <input type="password" placeholder="Skriv in lösenord" name="psw" required></input></center>
                </body>
                <body>
                    <div>
                        <body><center><button type="submit">Logga in</button></center></body>
                        <div>
                            <body><center>
                                <br />
                                <div class="psw">Glömt <a href="#">Lösenord?</a>
                                </div>
                                <br />
                                <input type="checkbox" checked="checked" name="remember" /> Komma ihåg
                                    </center></body>
                                                        
                        </div>
                    </div>
                </body>
            </div>
        )
    }
}
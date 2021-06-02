import Card from 'react-bootstrap/Card'
import React, { Component } from "react";
import CardDeck from 'react-bootstrap/CardDeck'
import Button from 'react-bootstrap/Button'
import "./Bikes.css";
import Container from 'react-bootstrap/esm/Container';

export class Bikes extends Component {

    render() {
        return (

        

          <Container>            


            <CardDeck className="deck">
                <Card className="card">
                <Card.Img variant="top" className="img" src="https://images.unsplash.com/flagged/photo-1561273560-469573e7e290?ixid=MnwxMjA3fDB8MHxzZWFyY2h8OTZ8fGJpa2UlMjByaWRpbmd8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60" />
                    <Card.Body>
                        <Card.Title>Stadscykel</Card.Title>
                        <Card.Text>
                    Elegant kvalitetscykel. Ram med lågt insteg och rymlig korg fram.
                  <div className="price">Pris 249:-</div>
                  </Card.Text>
                    </Card.Body>
                    <Card.Footer>
                        <Button variant="primary">Lägg till</Button>
                    </Card.Footer>
                </Card>
              <Card className="card">
                    <Card.Img variant="top" className="img" src="https://www.electricbike.com/wp-content/uploads/2020/08/Celebrity3.jpg" />
                    <Card.Body>
                        <Card.Title>Elcykel</Card.Title>
                        <Card.Text>
                    Passar bra vid längre sträckor eller om du vill ha lite extra hjälp i uppförsbackarna. Elmotorn hjälper dig upp till 25km/h.
                  <div className="price">Pris 249:-</div>
                  </Card.Text>
                    </Card.Body>
                    <Card.Footer>
                        <Button variant="primary">Lägg till</Button>
                    </Card.Footer>
                </Card>
              <Card className card>
                <Card.Img variant="top" className="img" src="https://images.unsplash.com/photo-1588935365434-fa1578152e18?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjR8fG1vdW50YWluJTIwYmlrZXxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60" />
                    <Card.Body>
                        <Card.Title>Mountainbike</Card.Title>
                        <Card.Text>
                    Vill du köra i lite tuffare terräng eller off-road passar denna cykel perfekt.{/* Med ställbar stöttdämpning fram får du en extra skön komfort på ett svårare underlag.*/}
                  <div className="price">Pris 269:-</div>
                  </Card.Text>
                    </Card.Body>
                    <Card.Footer>
                        <Button variant="primary">Lägg till</Button>
                    </Card.Footer>
                </Card>
              <Card className card>
                <Card.Img variant="top" className="img" src="https://image.freepik.com/free-photo/back-view-little-child-blue-coat-riding-bicycle_85672-2742.jpg" />
                    <Card.Body>
                        <Card.Title>Barncykel</Card.Title>
                        <Card.Text>
                    Klart att barnen ska med cykellturen. Vi har barncyklar.
      </Card.Text>
                        <div className="price">Pris 179:-</div>
                    </Card.Body>
                    <Card.Footer>
                        <Button variant="primary">Lägg till</Button>
                    </Card.Footer>
              </Card>
            </CardDeck>
            <br></br>
            <div><c>Priser avser per dag</c></div>
            </Container>
        )
    }
}

export default Bikes;

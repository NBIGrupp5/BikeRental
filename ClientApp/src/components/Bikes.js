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
                  En mountainbike eller terrängcykel är en typ av cykel som framförallt är avsedd att köras i terräng, där cyklarnas utformning även givit namn åt de olika motions- eller tävlingsdiscipliner som förekommer.
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
                  En mountainbike eller terrängcykel är en typ av cykel som framförallt är avsedd att köras i terräng, där cyklarnas utformning även givit namn åt de olika motions- eller tävlingsdiscipliner som förekommer.
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
                  MTB är en mountainbike cykel som är anpassad för barn. En mountainbike eller terrängcykel är en typ av cykel som framförallt är avsedd att köras i terräng, där cyklarnas utformning även givit namn åt de olika motions- eller tävlingsdiscipliner som förekommer..
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
                            Elcykel är en trampcykel som har försetts med en elektrisk motor som förstärker cyklistens trampkraft och som verkar endast då pedalerna rör sig. Cyklisten trampar som vanligt, men utan tungt motstånd och man kan lättare cykla långa sträckor, uppför backar och i motvind.
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

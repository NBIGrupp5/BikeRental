import Card from 'react-bootstrap/Card'
import React, { Component } from "react";
import CardDeck from 'react-bootstrap/CardDeck'
import Button from 'react-bootstrap/Button'
import "./Bikes.css";
import Container from 'react-bootstrap/esm/Container';
import { Link } from 'react-router-dom'

export class Bikes extends Component {

  constructor(props) {
    console.log(props)
    super(props)
    this.state = {
      bikes: []
    }
  }

  componentDidMount() {
    //fetch all the bikes data
    this.setState({
      bikes: [
        {
          id: '1',
          name: 'Stadscykel',
          description: 'Elegant kvalitetscykel. Ram med lågt insteg.',
          price: 249,
          imageUrl: 'https://images.unsplash.com/flagged/photo-1561273560-469573e7e290?ixid=MnwxMjA3fDB8MHxzZWFyY2h8OTZ8fGJpa2UlMjByaWRpbmd8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60'
        },
        {
          id: '2',
          name: 'Elcykel',
          description: 'Vill du köra i lite tuffare terräng eller off-road passar denna cykel perfekt.',
          price: 249,
          imageUrl: 'https://www.electricbike.com/wp-content/uploads/2020/08/Celebrity3.jpg'
        },
        {
          id: '3',
          name: 'Mountainbike',
          description: 'Vill du köra i lite tuffare terräng eller off-road passar denna cykel perfekt.',
          price: 269,
          imageUrl: 'https://images.unsplash.com/photo-1588935365434-fa1578152e18?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjR8fG1vdW50YWluJTIwYmlrZXxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60'
        },
        {
          id: '4',
          name: 'Barncykel',
          description: 'Klart att barnen ska med cykellturen. Vi har barncyklar.',
          price: 179,
          imageUrl: 'https://image.freepik.com/free-photo/back-view-little-child-blue-coat-riding-bicycle_85672-2742.jpg'
        },
      ]
    })
  }

  render() {
    return (
      <Container>

        <CardDeck className="deck">

          {this.state.bikes.map(bike => {
            return (
            <Card key={bike.id} className="card">
                <Card.Img variant="top" className="img" src={bike.imageUrl} />
            <Card.Body>
                  <Card.Title>{bike.name}</Card.Title>
                  <Card.Text>{bike.description}
                  </Card.Text>
                  <div className="price">{bike.price}:-</div>
            </Card.Body>
            <Card.Footer>
                  <Link to={{ pathname: 'BookingForm', state: { bike } }}>
                <Button variant="primary">Lägg till</Button>
              </Link>

            </Card.Footer>
          </Card>
            )
          })}
        </CardDeck>
        <br></br>
        <div>Priser avser per dag</div>
      </Container>
    )
  }
}

export default Bikes;
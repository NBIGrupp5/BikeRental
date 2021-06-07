import Card from 'react-bootstrap/Card'
import React, { Component } from "react";
import CardColumns from 'react-bootstrap/CardColumns'
import Button from 'react-bootstrap/Button'
import "./Bikes.css";
import Container from 'react-bootstrap/esm/Container';
import { withRouter } from 'react-router-dom';
import axios from 'axios';
import { Link } from 'react-router-dom';

//import history from './../history';

export class Bikes extends Component {

  nextPath(path) {
    this.props.history.push(path);
  }


  constructor(props) {
    super(props);
    this.state = {
      bikes: [],
      isLoading: true
    }
  }

  async componentDidMount() {
    const response = await axios.get("api/BikeTypes");

    this.setState({
      bikes: response.data,
      isLoading: false
    });
    console.log(response.data);
  }

  render() {

    const { isLoading, bikes } = this.state;
    
    return (
        <div>
          {!isLoading ? (
            bikes.map(bike => {
              const { id, bikeTypeName, bikeTypePrice, bikeTypeDescription, bikeTypeImage } = bike;

              return (
                <CardColumns>
                  <Card>
                    <Card.Img variant="top" src={bikeTypeImage} />
                    <Card.Body>
                      <Card.Title>{bikeTypeName}</Card.Title>
                      <Card.Text>
                        {bikeTypeDescription}
                      </Card.Text>
                      <div>pris {bikeTypePrice} ;-</div>
                    </Card.Body>
                    <Card.Footer>
                      <Link className="btn btn-primary" to={{
                        pathname: "/BookingForm",
                        state: {biketype: bike}
                      }} />
                    </Card.Footer>
                  </Card>
                </CardColumns>
              );
            })
          ) : (
              <p>Loading...</p>
            )}
        </div>

    );

  }


    createBikeElements() {
      let elements = [];
      for (let bike of this.state.bikes) {
        elements.push(<div key={bike.Id}></div>);
      }
      return (elements);
    }
}

export default withRouter(Bikes);


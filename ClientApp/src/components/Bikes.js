import Card from 'react-bootstrap/Card'
import React, { Component } from "react";
import CardColumns from 'react-bootstrap/CardColumns'
import "./Bikes.css";
import { withRouter } from 'react-router-dom';
import axios from 'axios';
import { Link } from 'react-router-dom';

//import history from './../history';

export class Bikes extends Component {


  constructor(props) {
    super(props);
    this.state = {
      biketypes: [],
      isLoading: true
    }
  }

  async componentDidMount() {
    const response = await axios.get("api/BikeTypes");

    this.setState({
      biketypes: response.data,
      isLoading: false
    });
    console.log(response.data);
  }

  render() {

    const { isLoading, biketypes } = this.state;

    return (
      <div>
          {!isLoading
            ? (
            biketypes.map(biketype => {
              const { id, bikeTypeName, bikeTypePrice, bikeTypeDescription, bikeTypeImage } = biketype;

                  return (
                      <CardColumns key={id}>
                          <Card>
                    <Card.Img className="img2" variant="top" src={bikeTypeImage} />

                    <Card.Body>
                      <Card.Title>{bikeTypeName}</Card.Title>
                      <Card.Text>
                        {bikeTypeDescription}
                      </Card.Text>
                        </Card.Body>
                    <div>pris {bikeTypePrice} ;-</div>
                    <Card.Footer>
                      <Link className="btn btn-primary" to={{
                        pathname: "/BookingForm",
                            state: { biketype: biketype }
                      }}>Hyra</Link>
                    </Card.Footer>
                  </Card>

                </CardColumns>

                );
              })
            )
            : (
              <p>Loading...</p>
            )}
        </div>
    );

  }
}


export default withRouter(Bikes);
import React, { Component, useState } from 'react';
import Container from 'react-bootstrap/Container';
import Image from 'react-bootstrap/Image';
import banner from './img/banner0.png';


export class Home extends Component {
    static displayName = Home.name;

    componentDidMount() {
        let bikes = fetch('api/bikes');
        console.log(bikes);
    }

    render() {
      return (         
            <div>
              <Container>                 
                  <Image src={banner} fluid />    
              </Container>
          </div>                 
        );
    }
}

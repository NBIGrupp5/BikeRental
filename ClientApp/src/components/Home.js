import React, { Component, useState } from 'react';
import Container from 'react-bootstrap/Container';
import Image from 'react-bootstrap/Image';
import banner from './img/banner0.png';


export class Home extends Component {
    static displayName = Home.name;


    render() {
      return (         
            <div>
          <Container className="bookingcontainer">                 
                  <Image src={banner} fluid />    
              </Container>
          </div>                 
        );
    }
}

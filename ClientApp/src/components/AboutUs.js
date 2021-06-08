import React from 'react';
import Image from 'react-bootstrap/Image';
import Container from 'react-bootstrap/Container'
import Col from 'react-bootstrap/Col'
import Row from 'react-bootstrap/Row'
import './AboutUs.css';


const ShowAboutUs = function AboutUs() {
  return (

    <div>
      <Container className="bookingcontainer" fluid>
        <Row>
                  <div>
                      <h1 style={{ padding: "14px" }} className="Omoss">Om oss</h1>
            </div>
        </Row>
        <Row>
            <Col>
            <p>Hos SWEBIKE kan du hyra cykel på olika destinationer i Göteborg. Vi finns på platser som har närhet till natur, kultur och cykelleder.
                Vi erbjuder citybikes, elcyklar, mountainbikes och barncyklar!
                Läs mer om våra destinationer och hyr cykel från den plats du vill upptäcka.</p>
            </Col>
            <Col>
                <Image src={require("./img/logo-photo.png")} padding="20px" fluid />
            </Col>
        </Row>
        <br/>
        <Row>
          <Col>
            <p>
            <br/>
                <a className="gmaps-link" href="https://www.google.com/maps/place/NBI%2FHandelsakademin/@57.6730902,11.8811027,149m/data=!3m1!1e3!4m12!1m6!3m5!1s0x464f8ccc7cd3a295:0x6f2f1bcdd22f70e5!2sNBI%2FHandelsakademin!8m2!3d57.6731594!4d11.8813052!3m4!1s0x464f8ccc7cd3a295:0x6f2f1bcdd22f70e5!8m2!3d57.6731594!4d11.8813052">
                        <Image src="https://i.imgur.com/noA2VPk.png" alt="handelsakademin" fluid /></a>
            </p>
           </Col>
           <Col>
                <h2>Hitta oss:</h2>
                <br />
                <p>Vi tar emot: <img src="https://i.imgur.com/6kKig18.jpg" width="25" height="25" />
                    <img src="https://i.imgur.com/NsaNnrC.jpg" width="40" height="25" />
                    <img src="https://i.imgur.com/2RkrFOK.jpg" width="40" height="25" /></p>
           </Col>
        </Row>
      </Container>
    </div>
  );
}
export default ShowAboutUs;
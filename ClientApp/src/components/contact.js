import React from 'react';
import Image from 'react-bootstrap/Image';
import Container from 'react-bootstrap/Container'
import Col from 'react-bootstrap/Col'
import Row from 'react-bootstrap/Row'
import './contact.css';


const contact = function contact() {
    return (

        <div>
        <Container className="bookingcontainer" fluid>
                <Row>
                    <div>
                        <h1 style={{ padding: "14px" }}>Kontakta Oss</h1>
                    </div>
                </Row>
                <Row>
                    <Col>
                        <p>Om du har en fråga, tveka inte på att kontakta oss.<br /><br/>
                         Redegatan 1H, 426 77 Västra Frölunda<br/>
                         Telefonnummer:  +4631 70 46 700<br/>
                         Email: Swebike@hotmail.com<br />
                        </p>
                    </Col>
                    <Col>
                        <Image src={require("./img/logo-photo.png")} padding="20px" fluid />
                    </Col>
                </Row>
            </Container>
        </div>
    );
}
export default contact;
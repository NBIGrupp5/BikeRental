import React, { Component, useState } from 'react';
import Container from 'react-bootstrap/Container';
import Image from 'react-bootstrap/Image';
import banner from './img/banner0.png';
import DatePicker from "react-datepicker";
import moment from 'moment';
import "react-datepicker/dist/react-datepicker.css";

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
        <div>
            <Container fluid>
          <Image src={banner} fluid />
        </Container>
          <Calender />
        </div>
    );

    function Calender() {
      const [checkInDate, setCheckInDate] = useState(null);
      const [checkOutDate, setCheckOutDate] = useState(null);

      const handleCheckInDate = (date) => {
        setCheckInDate(date);
        setCheckOutDate(null);
      };

      const handleCheckOutDate = (date) => {
        setCheckOutDate(date);
      };

      return (
        <div className="App">
          <div className="input-container">
            <div>
              <br />
              <label>Pick-up</label>
              <DatePicker
                selected={checkInDate}
                minDate={new Date()}
                onChange={handleCheckInDate}
              />
            </div>
            <div>
              <label>Return</label>
              <DatePicker
                selected={checkOutDate}
                minDate={checkInDate}
                onChange={handleCheckOutDate}
              />
            </div>
          </div>
          {checkInDate && checkOutDate && (
            <div className="summary">
              <p>
                You book a bicycle from {moment(checkInDate).format("LL")} to{" "}
                {moment(checkOutDate).format("LL")}.
          </p>
            </div>
          )}
        </div>
      );
    }
  }


}

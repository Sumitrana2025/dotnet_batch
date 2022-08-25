import React, { Component } from 'react';

export class School1 extends Component {
  constructor(props) {
    super(props);
    this.state = { name: 'St. Xavier High School', place: 'Bhayandar' };
  }
  render() {
    return (
      <div>
        <h3>My School name is {this.state.name}</h3>
      </div>
    );
  }
}

export default School1;

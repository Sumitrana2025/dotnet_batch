import React, { Component } from 'react';

class Phone extends Component {
    constructor(props){
        super(props);
        this.state={brand:"OnePlus" ,model:"Nord CE2 lite"};
    }
  render() {
    return (
      <div>
        <h1>
            My Phone is {this.state.model}
        </h1>
      </div>
    )
  }
}

export default Phone



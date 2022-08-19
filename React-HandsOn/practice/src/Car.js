import React, {Component} from 'react';

class Car extends Component{
    constructor(props){
        super(props);
        this.state={brand:"Ford"};
        this.state={carname:"Ford"};
        this.state={carbrandname:"Ford"};
        this.state={make:"Ford"};
        this.state={model:"Ford"};
        this.state={brand:"Tata"};
        

    }
    render(){
        return(
            <div>
                <h1>My Car is  {this.state.brand}</h1>
            </div>
        );

        }

    }
export default Car;

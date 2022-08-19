import React, {Component} from 'react';

class Engine extends Component{
    constructor(props){
        super(props);
        this.state={brand : "FORD",model : "xyz"};

    }
    render(){
        return(
            <div>
                <h1>My Car is of {this.state.brand}</h1>
            </div>
        );

        }

    }
export default Engine

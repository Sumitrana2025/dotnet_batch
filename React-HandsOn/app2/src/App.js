import logo from './logo.svg';
import './App.css';

function App() {
  return <div className="App">
    <AppChild battery="80%" />
     
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
}

function AppChild(props){
  return <span>
      The battery is {props.battery}
    </span>
}
    

export default App;

//import logo from './logo.svg';
import './App.css';


function App(){
  return <div>
    <AppChild name="Matt" />
    </div>
}

function AppChild(props){
  return <span>
      My name is {props.name}
    </span>
}

//ReactDOM.render(<App />, document.getElementById('app'));

// function App() {
//   return (
//     <div className="App">
//       <header className="App-header">
//         <img src={logo} className="App-logo" alt="logo" />
//         <p>
//           Edit <code>src/App.js</code> and save to reload.
//         </p>
//         <a
//           className="App-link"
//           href="https://reactjs.org"
//           target="_blank"
//           rel="noopener noreferrer"
//         >
//           Learn React
//         </a>
//       </header>
//     </div>
//   );
// }

export default App;

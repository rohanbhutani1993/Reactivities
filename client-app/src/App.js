import React from 'react';
import axios from 'axios';

class App extends React.Component {
    state = {
        values: []
    }

    componentDidMount() {
        axios.get('https://localhost:44360/api/values')
            .then((response) => {
                this.setState({ values: response.data }); 
            })
    }

    render() {
        return (
            <div className="App">
                <ul>
                    {this.state.values.map((value: any) => (
                        <li key={value.id}>{value.name}</li>
                        ))}
                </ul>
            </div>
        );
    }
}

export default App;

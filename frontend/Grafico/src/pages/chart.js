import React, { PureComponent } from 'react';
import xptoService from '../services/xptoService'
import {
  BarChart, Bar, Cell, XAxis, YAxis, CartesianGrid, Tooltip, Legend,
} from 'recharts';

  export default class Charts extends PureComponent {
    constructor(props){
        super(props);
        this.state = {
            dados: []
        }
    }

    async componentDidMount(){
        const { data } = await xptoService.get();
        console.log('data: ', data);
        this.setState({
          ...this.state,
          dados: data.result
        })
    }
  
    render() {
      return (
        <BarChart
          width={700}
          height={400}
          data={this.state.dados}
          margin={{
            top: 5, right: 30, left: 20, bottom: 5,
          }}
        >
          <CartesianGrid strokeDasharray="3 3" />
          <YAxis />
          <Tooltip />
          <Legend />
          <Bar dataKey="planejados" fill="#8884d8" />
          <Bar dataKey="produzidos" fill="#82ca9d" />
        </BarChart>
      );
    }
  }
  
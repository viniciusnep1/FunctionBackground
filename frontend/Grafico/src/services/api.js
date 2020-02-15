
import axios from 'axios';

const api = axios.create({
	baseURL: 'https://localhost:44303',
});


api.interceptors.request.use(
	(config) => {
		return config;
	},
	(error) => {
		return Promise.reject(error);
	},
);

api.interceptors.response.use(
	(response) => {
		return response;
	},
	(error) => {
		if(error.response) {
			if (error.response.data.status === 500) {
				alert('Ocorreu um erro no sistema, contate o administrador do sistema.');
			}
		}

		return Promise.reject(error);
	},
);

export default api;

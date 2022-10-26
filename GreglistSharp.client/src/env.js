export const dev = window.location.origin.includes('localhost')
export const baseURL = dev ? 'https://localhost:7045' : ''
export const useSockets = false
export const domain = 'erictim.us.auth0.com'
export const clientId = '6xePrWzHTnB6GgciYbt92k0N2gX831rr'
export const audience = 'https://myapp.com'
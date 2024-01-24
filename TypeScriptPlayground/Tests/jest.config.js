module.exports = {
  testEnvironment: "node", // or 'jsdom' for browser-like environment
  moduleFileExtensions: ["ts", "tsx", "js", "jsx"],
  transform: {
    "^.+\\.(ts|tsx)$": "ts-jest",
  },
  testRegex: "(/__tests__/.*|(\\.|/)(test|spec))\\.(jsx?|tsx?)$",
  collectCoverageFrom: [
    "src/**/*.{ts,tsx,js,jsx}",
    "!**/node_modules/**",
    "!**/vendor/**",
  ],
  // ... other configurations
};
cd;

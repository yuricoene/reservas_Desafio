import { ReservationForm, ReservationList, useReservations } from '../features/reservations';
import '../shared/styles/App.css';

function App() {
  const { reservations, loading, reload, cancel } = useReservations();

  return (
    <div className="app">
      <header>
        <h1>Reservas do Coworking</h1>
        <p>Gerencie as salas de reunião</p>
      </header>

      <div className="main-content">
        <ReservationForm onCreated={reload} />
        <ReservationList
          reservations={reservations}
          onCancel={cancel}
          loading={loading}
        />
      </div>
    </div>
  );
}

export default App;

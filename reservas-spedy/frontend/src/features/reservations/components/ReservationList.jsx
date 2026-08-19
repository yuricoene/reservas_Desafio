import ReservationCard from './ReservationCard';

export default function ReservationList({ reservations, onCancel, loading }) {
  if (loading) {
    return <div className="loading">Carregando reservas...</div>;
  }

  if (!reservations || reservations.length === 0) {
    return (
      <div className="empty-state">
        <p>Nenhuma reserva encontrada.</p>
        <p>Crie a primeira reserva usando o formulário acima.</p>
      </div>
    );
  }

  // Agrupar por dia
  const grouped = reservations.reduce((acc, reservation) => {
    const date = new Date(reservation.start);
    const key = date.toLocaleDateString('pt-BR', {
      weekday: 'long',
      day: '2-digit',
      month: 'long',
      year: 'numeric'
    });

    if (!acc[key]) acc[key] = [];
    acc[key].push(reservation);
    return acc;
  }, {});

  return (
    <div className="list-section">
      <h2>Reservas</h2>
      {Object.entries(grouped).map(([day, items]) => (
        <div key={day} className="day-group">
          <div className="day-title">{day}</div>
          {items.map((reservation) => (
            <ReservationCard
              key={reservation.id}
              reservation={reservation}
              onCancel={onCancel}
            />
          ))}
        </div>
      ))}
    </div>
  );
}

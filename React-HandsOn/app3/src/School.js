function School() {
  return (
    <div schoolName='St. Xavier High School'>
      <SchoolChild place='Bhayandar' />
    </div>
  );
}
function SchoolChild(props) {
  return <span>The School is in {props.place}</span>;
}

export default School;

import Image from "next/image";
import printables from "./dataTesting";
import Tiles from "./tiles";

export default function Home() {
  return (
    <div>
      <header>
        <p>3D Print Store</p>
    </header>

    <main>
        <section class="items-container">
            <Tiles printable={ printables[0] } />

            <Tiles printable={ printables[1] } />

            <Tiles printable={ printables[2] } />

            <Tiles printable={ printables[3] } />

            <Tiles printable={ printables[4] } />
        </section>
    </main>
    </div>
  );
}
